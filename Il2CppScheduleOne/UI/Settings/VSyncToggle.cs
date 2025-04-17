using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000698 RID: 1688
	public class VSyncToggle : SettingsToggle
	{
		// Token: 0x0600962D RID: 38445 RVA: 0x002679A0 File Offset: 0x00265BA0
		// Note: this type is marked as 'beforefieldinit'.
		static VSyncToggle()
		{
			Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "VSyncToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr);
			VSyncToggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr, 100681865);
			VSyncToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr, 100681866);
			VSyncToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr, 100681867);
		}

		// Token: 0x0600962E RID: 38446 RVA: 0x00267A0C File Offset: 0x00265C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269271, XrefRangeEnd = 269277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VSyncToggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600962F RID: 38447 RVA: 0x00267A48 File Offset: 0x00265C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269277, XrefRangeEnd = 269286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VSyncToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009630 RID: 38448 RVA: 0x00267A94 File Offset: 0x00265C94
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VSyncToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VSyncToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009631 RID: 38449 RVA: 0x00048E2F File Offset: 0x0004702F
		public VSyncToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400653D RID: 25917
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x0400653E RID: 25918
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400653F RID: 25919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
