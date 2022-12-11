using UnityEngine;
using UnityEngine.VFX;
using System.Collections;
using System.Collections.Generic;

namespace Reaktion
{
   // [AddComponentMenu("Reaktion/Gear/Material Gear")]
    public class VFXGear : MonoBehaviour
    {
        public enum TargetType { Color, Float, Vector, Texture }

        public ReaktorLink reaktor;

        public int materialIndex;

        public string targetName = "_Color";
        public TargetType targetType = TargetType.Color;

        public float threshold = 0.5f;

        public Gradient colorGradient;

        public AnimationCurve floatCurve = AnimationCurve.Linear(0, 0, 1, 1);

        public Vector4 vectorFrom = Vector4.zero;
        public Vector4 vectorTo = Vector4.one;

        public Texture textureLow;
        public Texture textureHigh;
        public VisualEffect effect;

        Material material;
        //public string[] materialNames = new string[4];


        void Awake()
        {
        }
        //void Start()
        //{
        //    //materialNames[0] = "_EmissionColor";
        //    //materialNames[1] = "_E1";
        //    //materialNames[2] = "_E2";
        //    //materialNames[3] = "_E3";
        //}

        void Update()
        {
            UpdateMaterial(reaktor.Output);
        }

        void UpdateMaterial(float param)
        {
            switch (targetType)
            {
               
                    //material.EnableKeyword("_EMISSION");
                    //if (targetName == materialNames[0])
                    //{
                    //material.SetColor(targetName, GetComponent<Renderer>().material.color = new Color(0.07f - param, 1f - param, 1f, 1.0f));                    
                    //}
                    //if (targetName == materialNames[1])
                    //{
                    //    material.SetColor(targetName, GetComponent<Renderer>().material.color = new Color(param, 1 - param, 0, 1));
                    //    Debug.Log(param);
                    //}
                    //if (targetName == materialNames[2])
                    //{
                    //    material.SetColor(targetName, GetComponent<Renderer>().material.color = new Color(1 - param, param, 0, 1));
                    //}
                    //if (targetName == materialNames[3])
                    //{
                    //    material.SetColor(targetName, GetComponent<Renderer>().material.color = new Color(1 - param, param, 0, 1));
                    //}

                   
                case TargetType.Float:
                    effect.SetFloat(targetName, floatCurve.Evaluate(param));
                    break;
              
            }
        }
    }

} // namespace Reaktion
