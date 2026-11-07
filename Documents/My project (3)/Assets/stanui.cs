using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stanui : MonoBehaviour
{
    public static float stungage = 0;
    public static Slider slider;
    public static bool stun_on_off = false;
    //-----------------------------------------------------------
    // ��礵���댝�󣨤�����Behaviour�ˉ������Ƥ��룩
    [SerializeField] private Behaviour _target;
    // �������[s]
    [SerializeField] private float _cycle;
    private double _time;
    //-----------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = stungage;
    }

    // Update is called once per frame
    void Update()
    {
        if (stungage > 1)
        {
            stungage -= 0.04f;
            slider.value = stungage;
        }


        if (stungage >= 0 && stun_on_off)
        {
            stungage -= 0.1f;
            slider.value = stungage;
            if (stungage < 0)
            {
                stungage = 0;
            }
        }


        if (stungage > 99)
        {
            stun_on_off = true;
        }
        else
        {
            _target.enabled = false;
        }
        /*
        
         */
        if (stun_on_off)
        {
            // �ڲ��r�̤�U�^������
            _time += Time.deltaTime;
            // ����cycle���R�귵������ȡ��
            // 0��cycle�ι���΂����ä���
            var repeatValue = Mathf.Repeat((float)_time, _cycle);

            // �ڲ��r��time�ˤ���������״�B��ӳ
            _target.enabled = repeatValue >= _cycle * 0.5f;

        }

        if (stungage == 0)
        {
            stun_on_off = false;
        }

        slider.value = stungage;
    }
}