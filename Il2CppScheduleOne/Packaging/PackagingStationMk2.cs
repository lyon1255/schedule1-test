using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000566 RID: 1382
	public class PackagingStationMk2 : PackagingStation
	{
		// Token: 0x0600791A RID: 31002 RVA: 0x0020ACF8 File Offset: 0x00208EF8
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationMk2()
		{
			Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "PackagingStationMk2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr);
			PackagingStationMk2.NativeFieldInfoPtr_PackagingTool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr, "PackagingTool");
			PackagingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted");
			PackagingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted");
			PackagingStationMk2.NativeMethodInfoPtr_StartTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr, 100678480);
			PackagingStationMk2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr, 100678481);
			PackagingStationMk2.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr, 100678482);
			PackagingStationMk2.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr, 100678483);
			PackagingStationMk2.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr, 100678484);
			PackagingStationMk2.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr, 100678485);
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x0020ADDC File Offset: 0x00208FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232707, XrefRangeEnd = 232734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationMk2.NativeMethodInfoPtr_StartTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x0020AE18 File Offset: 0x00209018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232734, XrefRangeEnd = 232735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationMk2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationMk2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationMk2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x0020AE54 File Offset: 0x00209054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232735, XrefRangeEnd = 232736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationMk2.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x0020AE90 File Offset: 0x00209090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232736, XrefRangeEnd = 232737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationMk2.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x0020AECC File Offset: 0x002090CC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationMk2.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x0020AF08 File Offset: 0x00209108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232737, XrefRangeEnd = 232738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationMk2.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x0003982E File Offset: 0x00037A2E
		public PackagingStationMk2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x0020AF44 File Offset: 0x00209144
		// (set) Token: 0x06007923 RID: 31011 RVA: 0x00039837 File Offset: 0x00037A37
		public unsafe PackagingTool PackagingTool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationMk2.NativeFieldInfoPtr_PackagingTool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationMk2.NativeFieldInfoPtr_PackagingTool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x06007924 RID: 31012 RVA: 0x0020AF74 File Offset: 0x00209174
		// (set) Token: 0x06007925 RID: 31013 RVA: 0x00039856 File Offset: 0x00037A56
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x06007926 RID: 31014 RVA: 0x0020AF9C File Offset: 0x0020919C
		// (set) Token: 0x06007927 RID: 31015 RVA: 0x00039871 File Offset: 0x00037A71
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005273 RID: 21107
		private static readonly IntPtr NativeFieldInfoPtr_PackagingTool;

		// Token: 0x04005274 RID: 21108
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005275 RID: 21109
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005276 RID: 21110
		private static readonly IntPtr NativeMethodInfoPtr_StartTask_Public_Virtual_Void_0;

		// Token: 0x04005277 RID: 21111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005278 RID: 21112
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005279 RID: 21113
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400527A RID: 21114
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400527B RID: 21115
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
