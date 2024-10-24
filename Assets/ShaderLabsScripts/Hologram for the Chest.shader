Shader "Custom/Holograms"
{
    Properties
    {
      _MainTex("Maintex", 2D) = "white"{}
      _RimColor("Rim Color", Color) = (0,0.5,0.5,0.0)
      _RimPower("Rim Power", Range(0.5,8.0)) = 3.0
       _Color ("Color", Color) = (1,1,1,1)
        _RampTex ("RampTexture", 2D) = "white"{}
         _ColorTint ("Tint", Color) = (1.0, 0.6, 0.6, 1.0)
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" }
     
        Pass {
            ZWrite On
            ColorMask 0 
            }

        CGPROGRAM
       
        #pragma surface surf ToonRamp finalcolor:mycolor

        
        float4 _Color;
        sampler2D _RampTex;
        sampler2D _MainTex;

                float4 LightingToonRamp (SurfaceOutput s, fixed3 lightDir, fixed atten)
        {            
            float diff = dot (s.Normal, lightDir);
            float h = diff * 0.3+0.3;
            float2 rh = h;
            float3 ramp = tex2D(_RampTex, rh).rgb;

            float4 c;
            c.rgb = s.Albedo * _LightColor0.rgb * (ramp);
            c.a = s.Alpha;
            return c;

        }

        struct Input
        {
            float3 viewDir;
            float2 uv_MainTex;
        };

         float4 _RimColor;
         float _RimPower;
         fixed4 _ColorTint;
        void mycolor (Input IN, SurfaceOutput o, inout fixed4 color){
               color *= _ColorTint;
            }

        void surf (Input IN, inout SurfaceOutput o)
        {
            o.Albedo = _Color.rgb;
            o.Albedo = tex2D (_MainTex, IN.uv_MainTex).rgb;
            half rim = 1.0 - saturate(dot(normalize(IN.viewDir), o.Normal));
            o.Emission = _RimColor.rgb * pow(rim, _RimPower) * 10;
            o.Alpha - pow(rim, _RimColor);
        }
        ENDCG
    }
    FallBack "Diffuse"
}
