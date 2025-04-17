using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B9 RID: 441
	public class Quest_DownToBusiness : Quest
	{
		// Token: 0x0600262B RID: 9771 RVA: 0x000E8540 File Offset: 0x000E6740
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_DownToBusiness()
		{
			Il2CppClassPointerStore<Quest_DownToBusiness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_DownToBusiness");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_DownToBusiness>.NativeClassPtr);
			Quest_DownToBusiness.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DownToBusiness>.NativeClassPtr, 100667567);
			Quest_DownToBusiness.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DownToBusiness>.NativeClassPtr, 100667568);
			Quest_DownToBusiness.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DownToBusiness>.NativeClassPtr, 100667569);
			Quest_DownToBusiness.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DownToBusiness>.NativeClassPtr, 100667570);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x000E85C0 File Offset: 0x000E67C0
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_DownToBusiness.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000E85FC File Offset: 0x000E67FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116697, XrefRangeEnd = 116716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_DownToBusiness.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x000E8638 File Offset: 0x000E6838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116716, XrefRangeEnd = 116730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DownToBusiness.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x000E866C File Offset: 0x000E686C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116730, XrefRangeEnd = 116734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_DownToBusiness() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_DownToBusiness>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DownToBusiness.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x000152F5 File Offset: 0x000134F5
		public Quest_DownToBusiness(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
