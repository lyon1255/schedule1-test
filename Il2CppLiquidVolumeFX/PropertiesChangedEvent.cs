using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D4 RID: 212
	public sealed class PropertiesChangedEvent : MulticastDelegate
	{
		// Token: 0x06000FA9 RID: 4009 RVA: 0x000A17E0 File Offset: 0x0009F9E0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertiesChangedEvent()
		{
			Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "PropertiesChangedEvent");
			PropertiesChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100665100);
			PropertiesChangedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100665101);
			PropertiesChangedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LiquidVolume_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100665102);
			PropertiesChangedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100665103);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x000A1858 File Offset: 0x0009FA58
		[CallerCount(632)]
		[CachedScanResults(RefRangeStart = 81883, RefRangeEnd = 82515, XrefRangeStart = 81883, XrefRangeEnd = 82515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertiesChangedEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000A18B4 File Offset: 0x0009FAB4
		[CallerCount(0)]
		public unsafe void Invoke(LiquidVolume lv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LiquidVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x000A18F8 File Offset: 0x0009FAF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(LiquidVolume lv, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LiquidVolume_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000A196C File Offset: 0x0009FB6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00009D1B File Offset: 0x00007F1B
		public PropertiesChangedEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00009D24 File Offset: 0x00007F24
		public static implicit operator PropertiesChangedEvent(Action<LiquidVolume> A_0)
		{
			return DelegateSupport.ConvertDelegate<PropertiesChangedEvent>(A_0);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00009D2C File Offset: 0x00007F2C
		public static PropertiesChangedEvent operator +(PropertiesChangedEvent A_0, PropertiesChangedEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PropertiesChangedEvent>();
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00009D3A File Offset: 0x00007F3A
		public static PropertiesChangedEvent operator -(PropertiesChangedEvent A_0, PropertiesChangedEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<PropertiesChangedEvent>();
			}
			return result;
		}

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LiquidVolume_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LiquidVolume_AsyncCallback_Object_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
