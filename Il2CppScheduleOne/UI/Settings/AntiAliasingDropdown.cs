using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000683 RID: 1667
	public class AntiAliasingDropdown : SettingsDropdown
	{
		// Token: 0x06009581 RID: 38273 RVA: 0x002654FC File Offset: 0x002636FC
		// Note: this type is marked as 'beforefieldinit'.
		static AntiAliasingDropdown()
		{
			Il2CppClassPointerStore<AntiAliasingDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "AntiAliasingDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntiAliasingDropdown>.NativeClassPtr);
			AntiAliasingDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiAliasingDropdown>.NativeClassPtr, 100681775);
			AntiAliasingDropdown.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiAliasingDropdown>.NativeClassPtr, 100681776);
			AntiAliasingDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiAliasingDropdown>.NativeClassPtr, 100681777);
			AntiAliasingDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiAliasingDropdown>.NativeClassPtr, 100681778);
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x0026557C File Offset: 0x0026377C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268499, XrefRangeEnd = 268533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AntiAliasingDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x002655B8 File Offset: 0x002637B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268533, XrefRangeEnd = 268539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AntiAliasingDropdown.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x002655F4 File Offset: 0x002637F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268539, XrefRangeEnd = 268555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AntiAliasingDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x00265640 File Offset: 0x00263840
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AntiAliasingDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntiAliasingDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntiAliasingDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x00048B3C File Offset: 0x00046D3C
		public AntiAliasingDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040064D2 RID: 25810
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040064D3 RID: 25811
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040064D4 RID: 25812
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0;

		// Token: 0x040064D5 RID: 25813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
