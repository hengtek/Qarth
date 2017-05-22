﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PTGame.Framework
{
    public class GuideCommand
    {
        private GuideStep m_GuideStep;

        public GuideStep guideStep
        {
            get { return m_GuideStep; }
            set { m_GuideStep = value; }
        }

		public virtual void SetParam(string param)
		{
			
		}

        protected void FinishStep()
        {
            if (m_GuideStep == null)
            {
                return;
            }

            m_GuideStep.Finish();
        }

        public virtual void Start()
        {
            //如果需要Update 直接用Timer就可以

        }

        public virtual void OnFinish()
        {

        }
    }
}