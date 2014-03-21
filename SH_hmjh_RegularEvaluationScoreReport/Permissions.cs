using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SH_hmjh_RegularEvaluationScoreReport
{
    class Permissions
    {
        public static string KeyHmjhRegularEvaluationScoreReport { get { return "SHSchool.SH_hmjh_RegularEvaluationScoreReport.cs"; } }
        public static bool IsEnableHmjhRegularEvaluationScoreReport
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[KeyHmjhRegularEvaluationScoreReport].Executable;
            }
        }
    }
}
