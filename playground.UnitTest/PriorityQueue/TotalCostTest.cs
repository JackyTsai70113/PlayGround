using playground.PriorityQueue;

namespace playground.UnitTest.PriorityQueue;

public class TotalCostTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 4, 5 }, 3, 2, 7)]
    [InlineData(new int[] { 1, 2, 4, 5 }, 3, 3, 7)]
    [InlineData(new int[] { 4, 5, 1, 2 }, 3, 3, 7)]
    [InlineData(new int[] { 1, 2, 4, 1 }, 3, 3, 4)]
    [InlineData(new int[] { 17, 12, 10, 2, 7, 2, 11, 20, 8 }, 3, 4, 11)]
    [MemberData(nameof(GetData))]
    public void TotalCost(int[] costs, int k, int ca, long expected)
    {
        var actual = TotalCostClass.TotalCost(costs, k, ca);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] {
            new int[] { 1625, 4417, 2997, 3078, 1094, 4679, 1017, 2461, 4690, 4590, 3891, 3089, 4991, 3552, 4992, 3111, 3021, 4527, 3302, 1057, 3447, 3565, 4358, 1099, 811, 2341, 2375, 1486, 2842, 1947, 4515, 1387, 1713, 4294, 3144, 3385, 3708, 3995, 3526, 468, 4074, 682, 4080, 3565, 2229, 4025, 2331, 2284, 3817, 4293, 681, 3282, 3258, 3373, 3161, 1505, 4543, 3899, 4585, 2927, 3558, 994, 4243, 1273, 3033, 2132, 2169, 4403, 2821, 454, 4797, 3841, 1494, 955, 4036, 765, 3726, 645, 2274, 2437, 1570, 1503, 4823, 4212, 2737, 3848, 2025, 4066, 4037, 609, 2545, 3441, 4187, 1650, 4339, 1574, 3314, 903, 4244, 4146, 2300, 2064, 2736, 2909, 3456, 4998, 2688, 2335, 4080, 1170, 1671, 4766, 4180, 4044, 4287, 4800, 1877, 759, 4900, 1990, 886, 617, 2334, 1960, 418, 1898, 4187, 451, 28, 1108, 3504, 438, 2051, 594, 470, 2379, 3755, 4986, 3983, 4556, 1871, 2521, 2183, 1243, 865, 2702, 2150, 3717, 2725, 4742, 4311, 3354, 2208, 644, 3576, 1433, 2784, 2704, 2222, 3014, 1074, 4359, 3820, 2410, 156, 2429, 1042, 3405, 3271, 1802, 254, 1426, 4973, 1210, 4785, 4594, 4040, 4899, 3743, 4023, 4650, 4284, 1804, 3465, 4006, 4952, 4332, 2930, 1664, 2275, 843, 4151, 4246, 1919, 3998, 307, 3968, 3531, 1739, 402, 2436, 1087, 1285, 454, 3734, 1350, 3468, 53, 4259, 230, 2238, 1719, 2753, 3528, 1898, 1348, 4156, 3697, 388, 2752, 3051, 447, 4883, 4147, 4417, 4965, 1661, 2749, 4253, 1682, 431, 4389, 2779, 982, 1417, 3013, 3437, 1629, 2675, 4126, 4819, 1568, 2411, 138, 3513, 4600, 1897, 2055, 3783, 3160, 1259, 390, 1255, 3685, 522, 2201, 3209, 4102, 4050, 368, 2939, 4774, 2570, 920, 1644, 4768, 244, 2508, 931, 3297, 1345, 601, 3873, 3221, 3016, 2179, 2845, 3936, 2521, 4276, 18, 685, 4282, 2600, 1639, 2692, 2630, 3689, 4009, 4889, 4651, 2995, 3216, 432, 666, 1713, 1861, 1145, 3525, 4454, 2100, 1411, 3708, 4693, 1896, 3022, 3652, 4390, 2068, 4633, 2113, 376, 718, 2112, 1590, 4142, 47, 2215, 278, 2403, 1184, 3789, 3522, 3629, 4995, 4613, 35756, 1027, 946, 4661, 2259, 1959, 2569, 3421, 4229, 3436, 2991, 2505, 723, 43, 1211, 4255, 241, 375, 108, 2130, 2489, 4738, 4547, 4122, 4781, 4909, 2476, 1747, 3837, 1285, 2860, 419, 1165, 3561, 2491, 3418, 4695, 356, 2586, 4189, 1797, 1785, 91, 1839, 2248, 3354, 4586, 3357, 611, 2520, 4091, 3788, 3355, 1364, 4815, 1811, 3476, 3387, 4666, 771, 2992, 14, 445, 2198, 2870, 3354, 4722, 1515, 257, 1809, 2660, 1404, 1384, 3838, 1134, 3331, 2094, 1178, 3205, 1381, 2722, 2741, 3540, 1510, 564, 1585, 119, 3049, 2506, 1273, 2108, 505, 1373, 1943, 412, 2652, 1549, 3347, 3970, 3889, 903, 22, 777, 1177, 3357, 2661, 949 },
            256,
            75,
            446506,
        };
    }
}
