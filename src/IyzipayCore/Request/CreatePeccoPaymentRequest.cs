﻿using System;

namespace IyzipayCore.Request
{
    public class CreatePeccoPaymentRequest : BaseRequest
    {
        public String Token { set; get; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("token", Token)
                .GetRequestString();
        }
    }
}
