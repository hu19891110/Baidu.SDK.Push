using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Diagnostics;
using Baidu.SDK.Push.Dto;
using Baidu.SDK.Push.Utility;
using Newtonsoft.Json;

namespace Baidu.SDK.Push
{
    /// <summary>
    /// Baidu Push Client
    /// </summary>
    public class Client
    {
        /// <summary>
        ///     访问令牌，明文AK，可从此值获得App的信息，配合sign中的sk做合法性身份认证
        /// </summary>
        public string Apikey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Default: 10000ms
        /// </summary>
        public int RequestTimeOut { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Client()
        {
            RequestTimeOut = 10000;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="secretkey"></param>
        public Client(string apiKey, string secretkey)
        {
            Apikey = apiKey;
            SecretKey = secretkey;
            RequestTimeOut = 10000;
        }

        #region 基础API
        /// <summary>
        /// Query Binds
        /// </summary>
        /// <param name="request">Query Binds request parameter</param>
        /// <returns></returns>
        public BindListQueryResponse QueryBindList(BindListQueryRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            BindListQueryResponse result = null;
            try
            {
                var serializerSettings = new JsonSerializerSettings();
                serializerSettings.Converters.Add(new UnixDateTimeConverter());

                result = JsonConvert.DeserializeObject<BindListQueryResponse>(response, serializerSettings);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("QueryBindList Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// Push Message Broadcast (to all users)
        /// </summary>
        /// <param name="request">Push request parameter</param>
        /// <returns></returns>
        public MessagePushResponse PushMessageBroadcast(MessagePushBroadcastRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            MessagePushResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<MessagePushResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("PushMessageBroadcast Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// Push Message to Tag 
        /// </summary>
        /// <param name="request">Push request parameter</param>
        /// <returns></returns>
        public MessagePushResponse PushMessageTag(MessagePushTagRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            MessagePushResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<MessagePushResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("PushMessageTag Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// Push Message to unicast (special user)
        /// </summary>
        /// <param name="request">Push request parameter</param>
        /// <returns></returns>
        public MessagePushResponse PushMessageUnicast(MessagePushUnicastRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            MessagePushResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<MessagePushResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("PushMessageUnicast Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// Init App IOS Cert
        /// </summary>
        /// <param name="request">Push request parameter</param>
        /// <returns></returns>
        public AppIOSCertInitResponse InitAppIOSCert(AppIOSCertInitRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            AppIOSCertInitResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<AppIOSCertInitResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("InitAppIOSCert Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// Update App IOS Cert
        /// </summary>
        /// <param name="request">Push request parameter</param>
        /// <returns></returns>
        public AppIOSCertUpdateResponse UpdateAppIOSCert(AppIOSCertUpdateRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            AppIOSCertUpdateResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<AppIOSCertUpdateResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("UpdateAppIOSCert Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// Delete App IOS Cert
        /// </summary>
        /// <param name="request">Push request parameter</param>
        /// <returns></returns>
        public AppIOSCertDeleteResponse DeleteAppIOSCert(AppIOSCertDeleteRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            AppIOSCertDeleteResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<AppIOSCertDeleteResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("DeleteAppIOSCert Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// Query App IOS Cert
        /// </summary>
        /// <param name="request">Push request parameter</param>
        /// <returns></returns>
        public AppIOSCertQueryResponse QueryAppIOSCert(AppIOSCertQueryRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            AppIOSCertQueryResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<AppIOSCertQueryResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("QueryAppIOSCert Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }
        #endregion

        #region 高级API

        /// <summary>
        /// verify_bind
        /// </summary>
        /// <param name="request">set tag request parameter</param>
        /// <returns></returns>
        public BindVerifyResponse VerifyBind(BindVerifyRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            BindVerifyResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<BindVerifyResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("VerifyBind Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        ///  fetch_msg
        /// </summary>
        /// <param name="request">set tag request parameter</param>
        /// <returns></returns>
        public MessageFetchResponse FetchMessage(MessageFetchRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            MessageFetchResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<MessageFetchResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("FetchMessage Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        ///  fetch_msgcount
        /// </summary>
        /// <param name="request">set tag request parameter</param>
        /// <returns></returns>
        public MessageCountFetchResponse FetchMessageCount(MessageCountFetchRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            MessageCountFetchResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<MessageCountFetchResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("FetchMessageCount Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// delete_msg
        /// </summary>
        /// <param name="request">set tag request parameter</param>
        /// <returns></returns>
        public MessageDeleteResponse DeleteMessage(MessageDeleteRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            MessageDeleteResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<MessageDeleteResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("FetchTag Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// set_tag
        /// </summary>
        /// <param name="request">set tag request parameter</param>
        /// <returns></returns>
        public TagSetResponse SetTag(TagSetRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            TagSetResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<TagSetResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("SetTag Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// fetch_tag
        /// </summary>
        /// <param name="request">set tag request parameter</param>
        /// <returns></returns>
        public TagFetchResponse FetchTag(TagFetchRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            TagFetchResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<TagFetchResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("FetchTag Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// delete_tag
        /// </summary>
        /// <param name="request">set tag request parameter</param>
        /// <returns></returns>
        public TagDeleteResponse DeleteTag(TagDeleteRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            TagDeleteResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<TagDeleteResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("DeleteTag Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// query_user_tags
        /// </summary>
        /// <param name="request">set tag request parameter</param>
        /// <returns></returns>
        public UserTagQueryResponse QueryUserTags(UserTagQueryRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            UserTagQueryResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<UserTagQueryResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("QueryUserTags Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }

        /// <summary>
        /// query_device_type
        /// </summary>
        /// <param name="request">set tag request parameter</param>
        /// <returns></returns>
        public DeviceTypeQueryResponse QueryDeviceType(DeviceTypeQueryRequest request)
        {
            var postStr = request.GeneratePostData(Apikey, SecretKey);

            var response = PostData(request.ServiceUrl, postStr);
            if (response == null)
                return null;

            DeviceTypeQueryResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<DeviceTypeQueryResponse>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("QueryDeviceType Error Response Deserialize Fail, May not valid json:" + ex.Message + " " + response);
            }
            return result;
        }
        #endregion

        #region Http Method
        /// <summary>
        /// POST data to server
        /// </summary>
        /// <param name="url">Server url</param>
        /// <param name="rquest">Push request data</param>
        /// <returns></returns>
        private string PostData(string url, string rquest)
        {
            string result = null;

            byte[] data = Encoding.UTF8.GetBytes(rquest);

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                request.ContentType = "application/x-www-form-urlencoded";
                request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.Reload);
                request.ServicePoint.Expect100Continue = false;
                request.Method = "POST";
                request.Timeout = RequestTimeOut;
                request.ContentLength = data.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                requestStream.Close();

                var response = (HttpWebResponse)request.GetResponse();
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        result = new StreamReader(responseStream, Encoding.UTF8).ReadToEnd();
                        responseStream.Close();
                        Debug.WriteLine("PostData OK Response:" + result);
                    }
                }
            }
            catch (WebException wex)
            {
                Debug.WriteLine("PostData WebException:" + wex.Status.ToString() + " " + wex.Message);
                if (wex.Response != null)
                {
                    using (var errStream = wex.Response.GetResponseStream())
                    {
                        if (errStream != null)
                        {
                            result = new StreamReader(errStream, Encoding.UTF8).ReadToEnd();
                            errStream.Close();
                            Debug.WriteLine("PostData Error Response:" + result);
                        }
                    }
                }
            }
            catch (Exception exx)
            {
                Debug.WriteLine("PostData Exception:" + exx.Message);
            }
            return result;
        }
        #endregion
    }
}
