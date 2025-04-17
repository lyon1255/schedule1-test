using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000371 RID: 881
	public sealed class ResponseCallback : MulticastDelegate
	{
		// Token: 0x060044B8 RID: 17592 RVA: 0x001532B0 File Offset: 0x001514B0
		// Note: this type is marked as 'beforefieldinit'.
		static ResponseCallback()
		{
			Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "ResponseCallback");
			ResponseCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr, 100671690);
			ResponseCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr, 100671691);
			ResponseCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr, 100671692);
			ResponseCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr, 100671693);
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00153328 File Offset: 0x00151528
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 83960, RefRangeEnd = 83964, XrefRangeStart = 83960, XrefRangeEnd = 83964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResponseCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00153384 File Offset: 0x00151584
		[CallerCount(0)]
		public unsafe void Invoke(string responseLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(responseLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x001533C8 File Offset: 0x001515C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(string responseLabel, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(responseLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x0015343C File Offset: 0x0015163C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x000218B1 File Offset: 0x0001FAB1
		public ResponseCallback(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x000218BA File Offset: 0x0001FABA
		public static implicit operator ResponseCallback(Action<string> A_0)
		{
			return DelegateSupport.ConvertDelegate<ResponseCallback>(A_0);
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x000218C2 File Offset: 0x0001FAC2
		public static ResponseCallback operator +(ResponseCallback A_0, ResponseCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ResponseCallback>();
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x000218D0 File Offset: 0x0001FAD0
		public static ResponseCallback operator -(ResponseCallback A_0, ResponseCallback A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<ResponseCallback>();
			}
			return result;
		}

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
