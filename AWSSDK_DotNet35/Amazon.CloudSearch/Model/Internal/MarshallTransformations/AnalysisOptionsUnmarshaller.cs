/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnalysisOptions Object
    /// </summary>  
    public class AnalysisOptionsUnmarshaller : IUnmarshaller<AnalysisOptions, XmlUnmarshallerContext>, IUnmarshaller<AnalysisOptions, JsonUnmarshallerContext>
    {
        public AnalysisOptions Unmarshall(XmlUnmarshallerContext context)
        {
            AnalysisOptions unmarshalledObject = new AnalysisOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AlgorithmicStemming", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AlgorithmicStemming = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("JapaneseTokenizationDictionary", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.JapaneseTokenizationDictionary = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StemmingDictionary", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StemmingDictionary = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Stopwords", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Stopwords = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Synonyms", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Synonyms = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public AnalysisOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static AnalysisOptionsUnmarshaller _instance = new AnalysisOptionsUnmarshaller();        

        public static AnalysisOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}