using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Establishments.Enums
{
    public enum Service : int
    {
        /// <summary>
        /// خدمة إصدار رخصة عمل
        /// </summary>
        WorkPermit = 1,

        /// <summary>
        /// خدمة الاستقدام الجماعي للمنشآت والشركات
        /// </summary>
        ExpirateLaborerRequest = 2,

        /// <summary>
        /// خدمة نقل خدمة عامل وافد
        /// </summary>
        TransferSponser = 3,

        /// <summary>
        /// خدمة تغيير المهنة
        /// </summary>
        ChangeJobDescription = 4,

        /// <summary>
        /// خدمة التوظيف للسعوديين
        /// </summary>
        Employment = 5,

        /// <summary>
        /// خدمة تغيير حالة العامل
        /// </summary>
        ChangeWorkerStatus = 11,

        /// <summary>
        /// الممثل الرئيسي للمنشأة
        /// </summary>
        EstablishmentMainAccount = 12,

        /// <summary>
        /// خدمة تغيير الفرع الحالى لعامل
        /// </summary>
        ChangeLaborerBranch = 13,

        /// <summary>
        /// خدمة تغيير نشاط المنشأة
        /// </summary>
        ChangeEstablishmentActivity = 14,

        /// <summary>
        /// طلب تاشيرات عمل
        /// </summary>
        ElectronicWorkVisa = 15,

        /// <summary>
        /// نظام حماية الأجور
        /// </summary>
        WageProtectionSystem = 16,

        /// <summary>
        /// خدمة أجير
        /// </summary>
        Ajeer = 18,

        /// <summary>
        /// خدمة أجير الموافقة
        /// </summary>
        AjeerApproval = 19,

        /// <summary>
        /// استخراج شهادة سعودة
        /// </summary>
        SaudiCertificateService = 17,

        /// <summary>
        /// خدمة رخص العمل المؤقته
        /// </summary>
        TempWorkPemit = 7,

        /// <summary>
        /// خدمة إلغاء التأشيرات
        /// </summary>
        CancelVisa = 21,

        /// <summary>
        /// خدمة إلغاء بلاغ الهروب
        /// </summary>
        CancelRunaway = 22,

        /// <summary>
        /// خدمة نقل خدمة العامل الفردى إلى منشآت
        /// </summary>
        IndividualSponsorTransfer = 23,

        /// <summary>
        /// خدمة إبلاغ عن هروب عامل
        /// </summary>
        LaborRunAwayService = 24,

        /// <summary>
        /// خدمة الخروج النهائى
        /// </summary>
        FinalExit = 8,

        /// <summary>
        /// خدمة تسجيل المتأخرين عن المغادرة من القادمين للحج والعمرة 
        /// </summary>
        HajjOmraCommers = 25,

        /// <summary>
        /// خدمة نقل خدمة المرافقين والمرافقات
        /// </summary>
        FollowerTransfer = 26,

        /// <summary>
        /// خدمة طلب رصيد تأشيرات
        /// </summary>
        IstqdmRequestVisaCredit = 27,

        /// <summary>
        /// خدمة طلب إصدار تأشيرات
        /// </summary>
        IstqdmRequestVisaIssue = 28,

        /// <summary>
        /// خدمة طلب تجاوز الحق المكتسب
        /// </summary>
        IstqdmRequestEarnedQuota = 29,

        /// <summary>
        /// خدمة الموعد الالكتروني
        /// </summary>
        OASIntegration = 30,

        /// <summary>
        /// خدمة طلب رصيد تأسيس أو توسع في النشاط
        /// </summary>
        VisaBalanceRequest = 50,

        /// <summary>
        /// خدمة طلب استثناء للإستقدام
        /// </summary>
        VisaBalanceIssueException = 52,

        /// <summary>
        /// خدمة إصدار التأشيرات
        /// </summary>
        VisaIssueRequest = 51,

        /// <summary>
        /// خدمة نقل العمالة بين العقود
        /// </summary>
        VisaBlanceTransfer = 53,
        /// <summary>
        /// خدمة تعديل ملف منشأة
        /// </summary>
        EditEstablishmentFile = 57,
    }
}
