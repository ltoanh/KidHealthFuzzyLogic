using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidHealthFuzzyLogic
{
    public static class Common
    {
        // độ tuổi
        public static int Age;
        // giới tính (0: nam, 1: nữ)
        public static int Gender;

        #region Chỉ số đánh giá
        // chiều cao
        public static double ChieuCao = 0.0;
        // cân nặng
        public static double CanNang = 0.0;
        // vận động thô
        public static int VDTH = 0;
        // vận động tinh
        public static int VDT = 0;

        #endregion

        #region Đồ thị 
        // 1. Chiều cao: Rất thấp (CC_RT), Thấp (CC_T), Bình thường (CC_BT), Cao hơn so với tuổi (CC_CH)
        // Tọa độ điểm: 
        public static Dictionary<string, List<double>> lsChieuCaoPoint = new Dictionary<string, List<double>>(){
            {"CC_RT", new List<double>(){ 0, 66, 77 } },
            {"CC_T", new List<double>(){ 66, 77, 79, 80 } },
            {"CC_BT", new List<double>(){ 79, 80, 90, 93 } },
            {"CC_CH", new List<double>(){ 91, 93, 110 } },
        };
        // Kết quả thực hiện mờ hóa tại từng tập mờ
        public static Dictionary<string, double> lsFuzzificationChieuCao = new Dictionary<string, double>(){
            {"CC_RT", 0.0},
            {"CC_T", 0.0 },
            {"CC_BT", 0.0 },
            {"CC_CH", 0.0 }
        };


        #endregion

    }
}
