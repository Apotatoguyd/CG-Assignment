Shader "Custom/Water"
{
    Properties
    {
        _MainTex ("Water", 2D) = "white" {}
        _SecondTex ("Foam", 2D) = "white" {}
        _Scrollx ("Scroll X", Range(-5,5)) = 1
        _Scrolly ("Scroll Y", Range(-5,5)) = 1
    }
    SubShader
    {
        CGPROGRAM
        #pragma surface surf Lambert
        float _Scrollx;
        float _Scrolly;
        sampler2D _SecondTex;
        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
            _Scrollx *= _Time/5;
            _Scrolly *= _Time/5;
            float3 water = tex2D(_MainTex, IN.uv_MainTex + float2(_Scrollx, _Scrolly)).rgb;
            float3 second = tex2D(_MainTex, IN.uv_MainTex + float2(_Scrollx/2.0, _Scrolly/2.0));
            
            o.Albedo = (water + second)/2.0;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
