using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteProject
{
    public class Verse
    {
        private int id;

        private string raw;
        private string cleaned;
        private float bestTime;

        public Verse(int id, string raw, string cleaned, float bestTime)
        {
            this.id = id;

            this.raw = raw;
            this.cleaned = cleaned;
            this.bestTime = bestTime;
        }

        public int GetId()
        {
            return id;
        }

        public string GetRaw()
        {
            return raw;
        }
        
        public string GetCleaned()
        {
            return cleaned;
        }

        public float GetBestTime()
        {
            return bestTime;
        }

        public void SetBestTime(float bestTime)
        {
            this.bestTime = bestTime;
        }
    }
}