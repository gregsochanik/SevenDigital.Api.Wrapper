﻿using SevenDigital.Api.Wrapper.Requests;

namespace SevenDigital.Api.Wrapper.Responses
{
	public class NullResponseCache : IResponseCache
	{
		public void Set(Response response, object value)
		{
			// don't store it
		}

		public bool TryGet<T>(Request request, out T value)
		{
			// nope, I don't have it
			value = default(T);
			return false;
		}
	}
}