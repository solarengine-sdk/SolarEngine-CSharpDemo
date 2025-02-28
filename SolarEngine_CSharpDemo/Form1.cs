using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SolarEngine;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("This is a message using Console.WriteLine11111");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {




        }


        public void logout(Object obj, EventArgs param)
        {
            SolarEngine.Analytics.logout();
        }

        public void init(Object obj, EventArgs param)
        {
            //预初始化
           SolarEngine.Analytics.preInitSeSdk("8b17c04df5df162a");


            //初始化
            SolarEngine.SEConfig config = new SolarEngine.SEConfig();
            config.isDebugModel = true;
            config.logEnabled = true;
            config.initCompletedCallback = initSuccessCallback;
            SolarEngine.Analytics.init("8b17c04df5df162a", SolarEngine.PackageType.ChinaMainland, config);
        }

        public void login(Object obj, EventArgs param)
        {
            SolarEngine.Analytics.login("loginid");
        }

        public void setChannel(Object obj, EventArgs param)
        {
            SolarEngine.Analytics.setChannel("google");
        }


        public void setSuperProperties(Object obj, EventArgs param)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("setSuperProperties", "SSSSSS");
        

            SolarEngine.Analytics.setSuperProperties(properties);
        }

        public void setPresetEvent(Object obj, EventArgs param)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("setPresetEvent", "PPPPP");


            SolarEngine.Analytics.setPresetEvent( PresetEventType.All,properties);
        }
        public void getAccountId(Object obj, EventArgs para)
        {
            Console.WriteLine(Analytics.getAccountId());

            MessageBox.Show(Analytics.getAccountId());
        }

        public void setVisitorId(Object obj, EventArgs para)
        {
            Analytics.setVisitorId("99999999999");
        }

        public void getVisitorId(Object obj, EventArgs para)
        {
            
            Console.WriteLine(Analytics.getVisitorId());
            MessageBox.Show(Analytics.getVisitorId());

        }

        public void getPresetProperties(Object obj, EventArgs para)
        {
            Console.WriteLine(JsonConvert.SerializeObject( Analytics.getPresetProperties()));
            MessageBox.Show(JsonConvert.SerializeObject(Analytics.getPresetProperties()));
        }

        public void reportEventImmediately(Object obj, EventArgs param)
        {

            SolarEngine.Analytics.reportEventImmediately();
        }


        public void eventStart(Object obj, EventArgs param)
        {

          
            SolarEngine.Analytics.eventStart("testeventStart");
        }

        public void eventFinish(Object obj, EventArgs param)
        {

            SolarEngine.Analytics.eventFinish("testeventStart", getCustomProperties());
        }


        public void trackAdClick(Object obj, EventArgs param)
        {

            Console.WriteLine("[se] trackAdClick click");

            AdClickAttributes AdClickAttributes = new AdClickAttributes();
            AdClickAttributes.ad_platform = "izz";
            AdClickAttributes.mediation_platform = "gromore_test";
            AdClickAttributes.ad_id = "product_id_test";
            AdClickAttributes.ad_type = 1;

            AdClickAttributes.customProperties = getCustomProperties();
            SolarEngine.Analytics.trackAdClick(AdClickAttributes);
        }

        public void trackRegister(Object obj, EventArgs param)
        {

            Console.WriteLine("[se] trackRegister click");

            RegisterAttributes RegisterAttributes = new RegisterAttributes();
            RegisterAttributes.register_type = "QQ_test";
            RegisterAttributes.register_status = "success";
            RegisterAttributes.customProperties = getCustomProperties();
            RegisterAttributes.checkId = "321";
           SolarEngine.Analytics.trackRegister(RegisterAttributes);

          //  SolarEngine.Analytics.trackFirstEvent(RegisterAttributes);
        }

        public void trackFirstEvent(Object obj, EventArgs param)
        {

            Console.WriteLine("[se] trackRegister click");
            CustomAttributes customAttributes = new CustomAttributes();
            customAttributes.checkId = "123";
            customAttributes.custom_event_name = "test1";
            Dictionary<string, object> customProperties = new Dictionary<string, object>();
            customProperties.Add("K1", "V1");
            customProperties.Add("K2", "V2");
            customProperties.Add("K3", 2);
            customAttributes.customProperties = customProperties;
            SolarEngine.Analytics.trackFirstEvent(customAttributes);
        }

        public void track(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] track custom click");

            Dictionary<string, object> customProperties = new Dictionary<string, object>();
            customProperties.Add("event001", 111);
            customProperties.Add("event002", "event002");
            customProperties.Add("event003", 1);

            Dictionary<string, object> preProperties = new Dictionary<string, object>();
            preProperties.Add("     ", 0.55);
            preProperties.Add("_currency_type", "USD");

            SolarEngine.Analytics.track("trackCustom", customProperties, preProperties);
        }

        public void trackAppAtrr(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] trackAppAtrr click");
            AttAttributes AppAttributes = new AttAttributes();
            AppAttributes.ad_network = "toutiao";
            AppAttributes.sub_channel = "103300";
            AppAttributes.ad_account_id = "1655958321988611";
            AppAttributes.ad_account_name = "xxx科技全量18";
            AppAttributes.ad_campaign_id = "1680711982033293";
            AppAttributes.ad_campaign_name = "小鸭快冲计划157-1024";
            AppAttributes.ad_offer_id = "1685219082855528";
            AppAttributes.ad_offer_name = "小鸭快冲单元406-1024";
            AppAttributes.ad_creative_id = "1680128668901378";
            AppAttributes.ad_creative_name = "自动创建20210901178921";
            AppAttributes.ad_creative_name = "自动创建20210901178921";
            AppAttributes.attribution_platform = "se";
            AppAttributes.customProperties = getCustomProperties();
            SolarEngine.Analytics.trackAttribution(AppAttributes);
        }

        public void trackIAP(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] trackIAP click");

            ProductsAttributes productsAttributes = new ProductsAttributes();
            productsAttributes.product_name = "product_name";
            productsAttributes.product_id = "product_id";
            productsAttributes.product_num = 8;
            productsAttributes.currency_type = "CNY";
            productsAttributes.order_id = "order_id";
            productsAttributes.fail_reason = "fail_reason";
            productsAttributes.paystatus = PayStatus.Success;
            productsAttributes.pay_type = "wechat";
            productsAttributes.pay_amount = 9.9;

            productsAttributes.customProperties = getCustomProperties();

            SolarEngine.Analytics.trackPurchase(productsAttributes);
        }

        public void trackAdImpression(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] trackAdImpression click");

            ImpressionAttributes impressionAttributes = new ImpressionAttributes();
            impressionAttributes.ad_platform = "AdMob";
            //impressionAttributes.ad_appid = "ad_appid";
            impressionAttributes.mediation_platform = "gromore";
            impressionAttributes.ad_id = "product_id";
            impressionAttributes.ad_type = 1;
            impressionAttributes.ad_ecpm = 0.8;
            impressionAttributes.currency_type = "CNY";
            impressionAttributes.is_rendered = true;
            impressionAttributes.customProperties = getCustomProperties();
            SolarEngine.Analytics.trackAdImpression(impressionAttributes);
        }

        public void trackLogin(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] trackLogin click");

            LoginAttributes LoginAttributes = new LoginAttributes();
            LoginAttributes.login_type = "QQ_test";
            LoginAttributes.login_status = "success1_test";
            LoginAttributes.customProperties = getCustomProperties();
            SolarEngine.Analytics.trackLogin(LoginAttributes);
        }

        public void trackOrder(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] trackOrderclick");

            OrderAttributes OrderAttributes = new OrderAttributes();
            OrderAttributes.order_id = "order_id_test";
            OrderAttributes.pay_amount = 10.5;
            OrderAttributes.currency_type = "CNY";
            OrderAttributes.pay_type = "AIP";
            OrderAttributes.status = "success";
            OrderAttributes.customProperties = getCustomProperties();

            SolarEngine.Analytics.trackOrder(OrderAttributes);
        }

        public void userInit(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] userInit click");

            Dictionary<string, object> userProperties = new Dictionary<string, object>();
            userProperties.Add("K1", "V1");
            userProperties.Add("K2", "V2");
            userProperties.Add("K3", 2);
            string[] arr = new string[] { "狐狸", "四叶草" };

            userProperties.Add("Kj", arr);
            SolarEngine.Analytics.userInit(userProperties);
        }

        public void userUpdate(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] userUpdate click");

            Dictionary<string, object> userProperties = new Dictionary<string, object>();
            userProperties.Add("K1", "V1");
            userProperties.Add("K2", "V2");
            userProperties.Add("K3", 2);
            SolarEngine.Analytics.userUpdate(userProperties);
        }

        public void userAdd(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] userAdd click");

            Dictionary<string, object> userProperties = new Dictionary<string, object>();
            userProperties.Add("K1", 10);
            userProperties.Add("K2", 100);
            userProperties.Add("K3", 2);
            SolarEngine.Analytics.userAdd(userProperties);
        }

        public void userUnset(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] userUnset click");

            SolarEngine.Analytics.userUnset(new string[] { "K1", "K2" });
        }

        public void userAppend(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] userAppend click");

            Dictionary<string, object> userProperties = new Dictionary<string, object>();
            userProperties.Add("K1", "V1");
            userProperties.Add("K2", "V2");
            userProperties.Add("K3", 2);
            SolarEngine.Analytics.userAppend(userProperties);
        }

        public void userDelete(Object obj, EventArgs param)
        {
            Console.WriteLine("[se] SEUserDeleteTypeByAccountId click");

            SolarEngine.Analytics.userDelete(UserDeleteType.ByAccountId);
            SolarEngine.Analytics.userDelete(UserDeleteType.ByVisitorId);
        }

        private void initSuccessCallback(int code)
        {
            MessageBox.Show("SEUnity:initSuccessCallback  code : " + code);
            Console.WriteLine("SEUnity:initSuccessCallback  code : " + code);
        }

        private Dictionary<string, object> getCustomProperties()
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("K1", "V1");
            properties.Add("K2", "V2");
            properties.Add("K3", 2);

            return properties;
        }
     
        private void getDistinctId(Object obj, EventArgs para)
        {
            Analytics.getDistinctId(_distinct);
        }

        private void _distinct(Distinct distinct)
        {
            Console.WriteLine(string.Format("distinct_id: {0} \n distinct_id_type: {1}", distinct.distinct_id, distinct.distinct_id_type));
            MessageBox.Show(string.Format("distinct_id: {0} \n distinct_id_type: {1}", distinct.distinct_id, distinct.distinct_id_type));
        }
    }
}