﻿/*
   Copyright 2016-2018 LIPtoH <liptoh.codebase@gmail.com>

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System.Collections.Generic;
using System.Linq;

namespace TS_SE_Tool
{
    class Routes
    {
        private List<string[]> RoutesList = new List<string[]>();
        private string[] SingleRoute;

        public void AddRoute(string _starting_city, string _starting_company, string _destination_city, string _destination_company, string _distance, string _ferry_time, string _ferry_price)
        {
            SingleRoute = new string[] { _starting_city, _starting_company, _destination_city, _destination_company, _distance, _ferry_time, _ferry_price};

            RoutesList.Add(SingleRoute);
        }

        public string[] GetRouteData(string _starting_city, string _starting_company, string _destination_city, string _destination_company)
        {

            string[] strArray = RoutesList.Find(x => x[0] == _starting_city && x[1] == _starting_company && x[2] == _destination_city && x[3] == _destination_company);

            if (strArray == null)
                return new string[] { _starting_city, _starting_company, _destination_city, _destination_company, "11111", "0", "0" };
            else
                return strArray;
        }

        public List<string[]> GetRoutes()
        {
            return RoutesList;
        }

        public int CountItems()
        {
            return RoutesList.Count();
        }

        public void ClearList()
        {
            RoutesList.Clear();
        }
    }
}
