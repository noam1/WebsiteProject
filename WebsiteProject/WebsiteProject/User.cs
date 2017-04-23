using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteProject
{
    public class User
    {
        private int id;
        private string fullName;
        private string userName;
        private string password;
        private string email;
        private int rank;
        private int tofiCount;
        private int solveCount;
        private int failCount;
        private float avgTypeSpeed;

        public User(int id, string fullName, string userName, string password, string email, int rank, int tofiCount, int solveCount, int failCount, float avgTypeSpeed)
        {
            this.id = id;
            this.fullName = fullName;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.rank = rank;
            this.tofiCount = tofiCount;
            this.solveCount = solveCount;
            this.failCount = failCount;
            this.avgTypeSpeed = avgTypeSpeed;
        }

        public int GetId()
        {
            return id;
        }

        public string GetFullName()
        {
            return fullName;
        }

        public void SetFullName(string fullName)
        {
            this.fullName = fullName;
        }

        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public int GetRank()
        {
            return rank;
        }

        public void SetRank(int rank)
        {
            this.rank = rank;
        }

        public int GetTofiCount()
        {
            return tofiCount;
        }

        public void SetTofiCount(int tofiCount)
        {
            this.tofiCount = tofiCount;
        }

        public int GetSolveCount()
        {
            return solveCount;
        }

        public void SetSolveCount(int solveCount)
        {
            this.solveCount = solveCount;
        }

        public int GetFailCount()
        {
            return failCount;
        }

        public void SetFailCount(int failCount)
        {
            this.failCount = failCount;
        }

        public float GetAvgTypeSpeed()
        {
            return avgTypeSpeed;
        }

        public void SetAvgTypeSpeed(float avgTypeSpeed)
        {
            this.avgTypeSpeed = avgTypeSpeed;
        }
    }
}