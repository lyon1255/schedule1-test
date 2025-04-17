using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000786 RID: 1926
	public class TimedAccessZone : AccessZone
	{
		// Token: 0x0600B65E RID: 46686 RVA: 0x002D4848 File Offset: 0x002D2A48
		// Note: this type is marked as 'beforefieldinit'.
		static TimedAccessZone()
		{
			Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "TimedAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr);
			TimedAccessZone.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, "OpenTime");
			TimedAccessZone.NativeFieldInfoPtr_CloseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, "CloseTime");
			TimedAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100685712);
			TimedAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100685713);
			TimedAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100685714);
			TimedAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100685715);
		}

		// Token: 0x0600B65F RID: 46687 RVA: 0x002D48F0 File Offset: 0x002D2AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310976, XrefRangeEnd = 310992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B660 RID: 46688 RVA: 0x002D492C File Offset: 0x002D2B2C
		[CallerCount(0)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B661 RID: 46689 RVA: 0x002D4968 File Offset: 0x002D2B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310992, XrefRangeEnd = 310998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetIsOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B662 RID: 46690 RVA: 0x002D49B0 File Offset: 0x002D2BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimedAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B663 RID: 46691 RVA: 0x000598E1 File Offset: 0x00057AE1
		public TimedAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600B664 RID: 46692 RVA: 0x002D49EC File Offset: 0x002D2BEC
		// (set) Token: 0x0600B665 RID: 46693 RVA: 0x000598EA File Offset: 0x00057AEA
		public unsafe int OpenTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_OpenTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_OpenTime)) = value;
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600B666 RID: 46694 RVA: 0x002D4A14 File Offset: 0x002D2C14
		// (set) Token: 0x0600B667 RID: 46695 RVA: 0x00059905 File Offset: 0x00057B05
		public unsafe int CloseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_CloseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_CloseTime)) = value;
			}
		}

		// Token: 0x04007AD9 RID: 31449
		private static readonly IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04007ADA RID: 31450
		private static readonly IntPtr NativeFieldInfoPtr_CloseTime;

		// Token: 0x04007ADB RID: 31451
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007ADC RID: 31452
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04007ADD RID: 31453
		private static readonly IntPtr NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0;

		// Token: 0x04007ADE RID: 31454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
