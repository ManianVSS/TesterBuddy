/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 15/03/2015
 * Time: 12:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;


namespace WebRequestHelperNS
{
    /// <summary>
    /// Description of MyClass.
    /// </summary>
    public class WebRequestHelper
    {

        public static bool ignorecertificates = true;

        public static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public static string GetURLResultPOST(string urlstring, List<KeyValuePair<string, string>> postparams, int timeout)
        {
            string postdata = "";

            if (urlstring.ToLower().StartsWith("https"))
            {
                if (ignorecertificates)
                {
                    ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
                }
            }

            //string []postparamarray=new string[postparams.Count];

            for (int i = 0; i < postparams.Count; i++)
            {
                postdata = postdata + postparams[i].Key + "=" + postparams[i].Value;

                if (i != (postparams.Count - 1))
                {
                    postdata = postdata + "&";
                }
            }

            WebRequest wr = WebRequest.Create(urlstring);
            wr.Method = "POST";
            wr.ContentLength = postdata.Length;
            wr.ContentType = "application/x-www-form-urlencoded";

            if (timeout > 0)
            {
                wr.Timeout = timeout;
            }

            Stream writeStream = wr.GetRequestStream();
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] bytes = encoding.GetBytes(postdata);
            writeStream.Write(bytes, 0, bytes.Length);

            writeStream.Close();

            HttpWebResponse response = (HttpWebResponse)wr.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(responseStream, Encoding.UTF8);
            string result = readStream.ReadToEnd();

            return result;
        }
    }
}