using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200068A RID: 1674
	public class GodRaysToggle : SettingsToggle
	{
		// Token: 0x060095C0 RID: 38336 RVA: 0x0026620C File Offset: 0x0026440C
		// Note: this type is marked as 'beforefieldinit'.
		static GodRaysToggle()
		{
			Il2CppClassPointerStore<GodRaysToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "GodRaysToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GodRaysToggle>.NativeClassPtr);
			GodRaysToggle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GodRaysToggle>.NativeClassPtr, 100681804);
			GodRaysToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GodRaysToggle>.NativeClassPtr, 100681805);
			GodRaysToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GodRaysToggle>.NativeClassPtr, 100681806);
		}

		// Token: 0x060095C1 RID: 38337 RVA: 0x00266278 File Offset: 0x00264478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268788, XrefRangeEnd = 268794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GodRaysToggle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095C2 RID: 38338 RVA: 0x002662B4 File Offset: 0x002644B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268794, XrefRangeEnd = 268810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GodRaysToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x00266300 File Offset: 0x00264500
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GodRaysToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GodRaysToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GodRaysToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x00048C7B File Offset: 0x00046E7B
		public GodRaysToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040064F9 RID: 25849
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040064FA RID: 25850
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040064FB RID: 25851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
