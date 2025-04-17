using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000696 RID: 1686
	public class SSAOToggle : SettingsToggle
	{
		// Token: 0x06009623 RID: 38435 RVA: 0x00267740 File Offset: 0x00265940
		// Note: this type is marked as 'beforefieldinit'.
		static SSAOToggle()
		{
			Il2CppClassPointerStore<SSAOToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SSAOToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSAOToggle>.NativeClassPtr);
			SSAOToggle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSAOToggle>.NativeClassPtr, 100681859);
			SSAOToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSAOToggle>.NativeClassPtr, 100681860);
			SSAOToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSAOToggle>.NativeClassPtr, 100681861);
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x002677AC File Offset: 0x002659AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269224, XrefRangeEnd = 269230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SSAOToggle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009625 RID: 38437 RVA: 0x002677E8 File Offset: 0x002659E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269230, XrefRangeEnd = 269246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SSAOToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009626 RID: 38438 RVA: 0x00267834 File Offset: 0x00265A34
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SSAOToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSAOToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSAOToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009627 RID: 38439 RVA: 0x00048E1D File Offset: 0x0004701D
		public SSAOToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006537 RID: 25911
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006538 RID: 25912
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04006539 RID: 25913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
