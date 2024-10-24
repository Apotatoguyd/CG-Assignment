Shader "Custom/Rocks"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MetallicTex ("Metallic (R)", 2D) = "white"{}
        _Metallic ("Metallic", Range(0.0, 1.0)) = 0.0
    }
    SubShader
    {
        Tags { "RenderType"="Geometry" }

        CGPROGRAM
  
        #pragma surface surf StandardSpecular


        sampler2D _MetallicTex;

        struct Input
        {
            float2 uv_MetallicTex;
        };

        half _Metallic;
        fixed4 _Color;



        void surf (Input IN, inout SurfaceOutputStandardSpecular o)
        {
         o.Albedo = _Color.rgb;
         o.Smoothness = tex2D(_MetallicTex, IN.uv_MetallicTex).r;
         o.Specular = _Metallic;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
