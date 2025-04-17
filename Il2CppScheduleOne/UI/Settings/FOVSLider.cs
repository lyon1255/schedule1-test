using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000688 RID: 1672
	public class FOVSLider : SettingsSlider
	{
		// Token: 0x060095B0 RID: 38320 RVA: 0x00265E98 File Offset: 0x00264098
		// Note: this type is marked as 'beforefieldinit'.
		static FOVSLider()
		{
			Il2CppClassPointerStore<FOVSLider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "FOVSLider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FOVSLider>.NativeClassPtr);
			FOVSLider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVSLider>.NativeClassPtr, 100681796);
			FOVSLider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVSLider>.NativeClassPtr, 100681797);
			FOVSLider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVSLider>.NativeClassPtr, 100681798);
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x00265F04 File Offset: 0x00264104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268742, XrefRangeEnd = 268747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FOVSLider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x00265F40 File Offset: 0x00264140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268747, XrefRangeEnd = 268764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FOVSLider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x00265F8C File Offset: 0x0026418C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FOVSLider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FOVSLider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVSLider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x00048C2B File Offset: 0x00046E2B
		public FOVSLider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040064EF RID: 25839
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040064F0 RID: 25840
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x040064F1 RID: 25841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
