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
        // Chiều cao
        public static Dictionary<string, string> lsChieuCaoName = new Dictionary<string, string>(){
            {"CC_RT", "Rất thấp"},
            {"CC_T", "Thấp" },
            {"CC_BT", "Bình thường" },
            {"CC_CH", "Cao hơn tuổi" }
        };

        // Cân nặng
        public static Dictionary<string, string> lsCanNangName = new Dictionary<string, string>(){
            {"CN_RG", "Rất gầy"},
            {"CN_G", "Gầy" },
            {"CN_BT", "Bình thường" },
            {"CN_TC", "Thừa cân" }
        };

        // Vận động thô
        public static Dictionary<string, string> lsVDTHName = new Dictionary<string, string>(){
            {"VDTH_RK", "Rất kém"},
            {"VDTH_K", "Kém" },
            {"VDTH_BT", "Bình thường" },
        };

        // Vận động tinh
        public static Dictionary<string, string> lsVDTName = new Dictionary<string, string>(){
            {"VDT_RK", "Rất kém"},
            {"VDT_K", "Kém" },
            {"VDT_BT", "Bình thường" },
        };

        // Đánh giá phát triển
        public static Dictionary<string, string> lsPhatTrienName = new Dictionary<string, string>(){
            {"PT_K", "Kém"},
            {"PT_HK", "Hơi Kém" },
            {"PT_HT", "Hơi tốt" },
            {"PT_T", "Tốt" },
        };

        #endregion

        #region Tọa độ điểm
        // 1. Chiều cao: Rất thấp (CC_RT), Thấp (CC_T), Bình thường (CC_BT), Cao hơn so với tuổi (CC_CH)
        // Tọa độ điểm: 
        public static Dictionary<string, List<double>> lsChieuCaoPointNu2 = new Dictionary<string, List<double>>(){
            {"CC_RT", new List<double>(){ 0, 66, 77 } },
            {"CC_T", new List<double>(){ 66, 77, 79, 80 } },
            {"CC_BT", new List<double>(){ 79, 80, 90, 93 } },
            {"CC_CH", new List<double>(){ 91, 93, 110 } },
        };
        public static Dictionary<string, List<double>> lsChieuCaoPointNam2 = new Dictionary<string, List<double>>(){
            {"CC_RT", new List<double>(){ 0, 69, 79 } },
            {"CC_T", new List<double>(){ 69, 72, 76, 82 } },
            {"CC_BT", new List<double>(){ 80, 83, 86, 94 } },
            {"CC_CH", new List<double>(){ 86, 94, 120 } },
        };

        // 2. Cân nặng: Rất gầy (CN_RG), Gầy (CN_G), Bình thường (CN_BT), Thừa cân (CN_TC)
        // Tọa độ điểm: 
        public static Dictionary<string, List<double>> lsCanNangPointNu2 = new Dictionary<string, List<double>>(){
            {"CN_RG", new List<double>(){ 0, 6, 7 } },
            {"CN_G", new List<double>(){ 6, 7, 8, 9 } },
            {"CN_BT", new List<double>(){ 8, 9, 11, 15 } },
            {"CN_TC", new List<double>(){ 11, 15, 25 } },
        };
        public static Dictionary<string, List<double>> lsCanNangPointNam2 = new Dictionary<string, List<double>>(){
            {"CN_RG", new List<double>(){ 0, 7, 8 } },
            {"CN_G", new List<double>(){ 7, 8, 9, 10 } },
            {"CN_BT", new List<double>(){ 9, 10, 12, 15 } },
            {"CN_TC", new List<double>(){ 12, 15, 25 } },
        };

        // 3. Vận động thô: Rất kém (VDTH_RK), Kém (VDTH_K), Bình thường (VDTH_BT)
        // Tọa độ điểm: 
        public static Dictionary<string, List<double>> lsVDTHPoint2 = new Dictionary<string, List<double>>(){
            {"VDTH_RK", new List<double>(){ 0, 35, 37 } },
            {"VDTH_K", new List<double>(){ 35, 37, 45, 48 } },
            {"VDTH_BT", new List<double>(){ 45, 48, 60 } },
        };

        // 4. Vận động tinh: Rất kém (VDTH_RK), Kém (VDTH_K), Bình thường (VDTH_BT)
        // Tọa độ điểm: 
        public static Dictionary<string, List<double>> lsVDTPoint2 = new Dictionary<string, List<double>>(){
            {"VDT_RK", new List<double>(){ 0, 33, 35 } },
            {"VDT_K", new List<double>(){ 33, 35, 43, 45 } },
            {"VDT_BT", new List<double>(){ 43, 45, 60 } },
        };

        // 5. Phát triển
        // Kết quả dùng để đánh giá sự phát triển theo từng tập luật
        public static Dictionary<string, List<double>> lsPhatTrienRule = new Dictionary<string, List<double>>()
        {
            {"PT_K", new List<double>(){ } },
            {"PT_HK", new List<double>(){ } },
            {"PT_HT", new List<double>(){ } },
            {"PT_T", new List<double>(){ } }
        };
        // Tọa độ điểm:
        public static Dictionary<string, List<double>> lsPhatTrienPoint = new Dictionary<string, List<double>>()
        {
            {"PT_K", new List<double>(){0.0, 0.2, 0.4} },
            {"PT_HK", new List<double>(){0.2, 0.4, 0.6} },
            {"PT_HT", new List<double>(){0.4, 0.6, 0.8} },
            {"PT_T", new List<double>(){0.6, 0.8, 1} }
        };

        #endregion

        // Kết quả thực hiện mờ hóa tại từng tập mờ
        #region Tập mờ
        // Chiều cao
        public static Dictionary<string, double> lsFuzzificationChieuCao = new Dictionary<string, double>(){
            {"CC_RT", 0.0},
            {"CC_T", 0.0 },
            {"CC_BT", 0.0 },
            {"CC_CH", 0.0 }
        };
        // Cân nặng
        public static Dictionary<string, double> lsFuzzificationCanNang = new Dictionary<string, double>(){
            {"CN_RG", 0.0 },
            {"CN_G", 0.0 },
            {"CN_BT", 0.0 },
            {"CN_TC", 0.0 },
        };
        // Vận động thô
        public static Dictionary<string, double> lsFuzzificationVDTH = new Dictionary<string, double>(){
            {"VDTH_RK", 0.0 },
            {"VDTH_K", 0.0 },
            {"VDTH_BT", 0.0 },
        };
        // Vận động tinh
        public static Dictionary<string, double> lsFuzzificationVDT = new Dictionary<string, double>(){
            {"VDT_RK", 0.0 },
            {"VDT_K", 0.0 },
            {"VDT_BT", 0.0 },
        };

        #endregion

        #region Giải mờ
        // Đánh giá phát triển (giải mờ)
        public static Dictionary<string, double> lsPhatTrienDefuzzy = new Dictionary<string, double>(){
            {"PT_K", 0.0},
            {"PT_HK", 0.0 },
            {"PT_HT", 0.0 },
            {"PT_T", 0.0 },
        };
        // Kết quả thực hiện giải mờ (hiển thị đồ thị)
        public static Dictionary<string, double> lsPhatTrienResult = new Dictionary<string, double>(){
            {"PT_K", 0.0},
            {"PT_HK", 0.0 },
            {"PT_HT", 0.0 },
            {"PT_T", 0.0 },
        };
        #endregion
    }
}
