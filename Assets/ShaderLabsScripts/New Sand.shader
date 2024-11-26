Shader "Custom/New Sand"
{
        Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _Bump("Bump tex2D", 2D) = "Bump"{}
        _BumpSlider ("Bump Texture", Range(0,10)) = 1
        _MetallicTex ("Metallic (R)", 2D) = "white"{}
        _Metallic ("Metallic", Range(0.0, 1.0)) = 0.0
         _ScrollX ("Scroll X", Range(-5,5)) = 1
        _ScrollY ("Scroll Y", Range(-5,5)) = 1
        _MainTex ("Main Texture", 2D) = "white" {}
        _ScrollTex ("Main Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Geometry" }

        CGPROGRAM
  
        #pragma surface surf StandardSpecular
        sampler2D _Bump;
        half _BumpSlider;
        sampler2D _MetallicTex;
        float _ScrollX;
        float _ScrollY;
        sampler2D _MainTex;
        sampler2D _ScrollTex;
        
        struct Input
        {
            float2 uv_MetallicTex;
            float2 uv_Bump;
            float2 uv_MainTex;
        };

        half _Metallic;
        fixed4 _Color;



        void surf (Input IN, inout SurfaceOutputStandardSpecular o)
        {
            _ScrollX *= _Time/5.0;
            _ScrollY *= _Time/5.0;
            float3 sand = tex2D(_MainTex, IN.uv_MainTex + float2(_ScrollX, _ScrollY)).rgb;
            float3 scroll = tex2D(_MainTex, IN.uv_MainTex + float2(_ScrollX/2.0, _ScrollY/2.0));
            float2 newuv = (IN.uv_MetallicTex, IN.uv_Bump) + float2(_ScrollX, _ScrollY);
            o.Albedo = (sand + scroll)*_Color.rgb;
            o.Smoothness = tex2D(_MetallicTex, IN.uv_MetallicTex).r;
            o.Specular = _Metallic;
            o.Normal = UnpackNormal(tex2D(_Bump, IN.uv_Bump));
            o.Normal *= float3(_BumpSlider, _BumpSlider,1);

        }
        ENDCG
    }
    FallBack "Diffuse"
}
