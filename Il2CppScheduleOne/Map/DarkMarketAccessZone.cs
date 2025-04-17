using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000773 RID: 1907
	public class DarkMarketAccessZone : TimedAccessZone
	{
		// Token: 0x0600B4F4 RID: 46324 RVA: 0x002D0638 File Offset: 0x002CE838
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketAccessZone()
		{
			Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarketAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr);
			DarkMarketAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr, 100685555);
			DarkMarketAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr, 100685556);
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x002D0690 File Offset: 0x002CE890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309667, XrefRangeEnd = 309679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetIsOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarketAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B4F6 RID: 46326 RVA: 0x002D06D8 File Offset: 0x002CE8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309679, XrefRangeEnd = 309680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4F7 RID: 46327 RVA: 0x00058C45 File Offset: 0x00056E45
		public DarkMarketAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040079F6 RID: 31222
		private static readonly IntPtr NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0;

		// Token: 0x040079F7 RID: 31223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
