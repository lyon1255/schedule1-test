using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000685 RID: 1669
	public class CameraBobSlider : SettingsSlider
	{
		// Token: 0x06009592 RID: 38290 RVA: 0x00265854 File Offset: 0x00263A54
		// Note: this type is marked as 'beforefieldinit'.
		static CameraBobSlider()
		{
			Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "CameraBobSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr);
			CameraBobSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100681782);
			CameraBobSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100681783);
			CameraBobSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100681784);
		}

		// Token: 0x06009593 RID: 38291 RVA: 0x002658C0 File Offset: 0x00263AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268600, XrefRangeEnd = 268605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraBobSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009594 RID: 38292 RVA: 0x002658FC File Offset: 0x00263AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268605, XrefRangeEnd = 268615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraBobSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009595 RID: 38293 RVA: 0x00265948 File Offset: 0x00263B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268615, XrefRangeEnd = 268616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraBobSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBobSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009596 RID: 38294 RVA: 0x00048B92 File Offset: 0x00046D92
		public CameraBobSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040064DC RID: 25820
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040064DD RID: 25821
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x040064DE RID: 25822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
