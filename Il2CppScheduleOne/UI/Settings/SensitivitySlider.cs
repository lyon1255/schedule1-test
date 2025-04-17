using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000691 RID: 1681
	public class SensitivitySlider : SettingsSlider
	{
		// Token: 0x060095F4 RID: 38388 RVA: 0x00266DC8 File Offset: 0x00264FC8
		// Note: this type is marked as 'beforefieldinit'.
		static SensitivitySlider()
		{
			Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SensitivitySlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr);
			SensitivitySlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, "MULTIPLIER");
			SensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100681840);
			SensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100681841);
			SensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100681842);
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x00266E48 File Offset: 0x00265048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269082, XrefRangeEnd = 269087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095F6 RID: 38390 RVA: 0x00266E84 File Offset: 0x00265084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269087, XrefRangeEnd = 269104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095F7 RID: 38391 RVA: 0x00266ED0 File Offset: 0x002650D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensitivitySlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095F8 RID: 38392 RVA: 0x00048D03 File Offset: 0x00046F03
		public SensitivitySlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x060095F9 RID: 38393 RVA: 0x00266F0C File Offset: 0x0026510C
		// (set) Token: 0x060095FA RID: 38394 RVA: 0x00048D0C File Offset: 0x00046F0C
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SensitivitySlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SensitivitySlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x0400651B RID: 25883
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x0400651C RID: 25884
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400651D RID: 25885
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x0400651E RID: 25886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
