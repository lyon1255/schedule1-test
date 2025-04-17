using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200068F RID: 1679
	public class QualityDropdown : SettingsDropdown
	{
		// Token: 0x060095E8 RID: 38376 RVA: 0x00266AC8 File Offset: 0x00264CC8
		// Note: this type is marked as 'beforefieldinit'.
		static QualityDropdown()
		{
			Il2CppClassPointerStore<QualityDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "QualityDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityDropdown>.NativeClassPtr);
			QualityDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityDropdown>.NativeClassPtr, 100681832);
			QualityDropdown.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityDropdown>.NativeClassPtr, 100681833);
			QualityDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityDropdown>.NativeClassPtr, 100681834);
			QualityDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityDropdown>.NativeClassPtr, 100681835);
		}

		// Token: 0x060095E9 RID: 38377 RVA: 0x00266B48 File Offset: 0x00264D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269009, XrefRangeEnd = 269028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x00266B84 File Offset: 0x00264D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269028, XrefRangeEnd = 269034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityDropdown.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x00266BC0 File Offset: 0x00264DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269034, XrefRangeEnd = 269050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x00266C0C File Offset: 0x00264E0C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x00048CF1 File Offset: 0x00046EF1
		public QualityDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006513 RID: 25875
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006514 RID: 25876
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006515 RID: 25877
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0;

		// Token: 0x04006516 RID: 25878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
