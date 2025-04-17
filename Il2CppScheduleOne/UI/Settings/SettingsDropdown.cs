using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000692 RID: 1682
	public class SettingsDropdown : MonoBehaviour
	{
		// Token: 0x060095FB RID: 38395 RVA: 0x00266F28 File Offset: 0x00265128
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsDropdown()
		{
			Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr);
			SettingsDropdown.NativeFieldInfoPtr_DefaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "DefaultOptions");
			SettingsDropdown.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "dropdown");
			SettingsDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100681843);
			SettingsDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100681844);
			SettingsDropdown.NativeMethodInfoPtr_AddOption_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100681845);
			SettingsDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100681846);
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x00266FD0 File Offset: 0x002651D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 269117, RefRangeEnd = 269123, XrefRangeStart = 269104, XrefRangeEnd = 269117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095FD RID: 38397 RVA: 0x0026700C File Offset: 0x0026520C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095FE RID: 38398 RVA: 0x00267058 File Offset: 0x00265258
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 269134, RefRangeEnd = 269141, XrefRangeStart = 269123, XrefRangeEnd = 269134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOption(string option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr_AddOption_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x0026709C File Offset: 0x0026529C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x00048D1A File Offset: 0x00046F1A
		public SettingsDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x06009601 RID: 38401 RVA: 0x002670D8 File Offset: 0x002652D8
		// (set) Token: 0x06009602 RID: 38402 RVA: 0x00048D23 File Offset: 0x00046F23
		public unsafe Il2CppStringArray DefaultOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_DefaultOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_DefaultOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x06009603 RID: 38403 RVA: 0x00267108 File Offset: 0x00265308
		// (set) Token: 0x06009604 RID: 38404 RVA: 0x00048D42 File Offset: 0x00046F42
		public unsafe TMP_Dropdown dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400651F RID: 25887
		private static readonly IntPtr NativeFieldInfoPtr_DefaultOptions;

		// Token: 0x04006520 RID: 25888
		private static readonly IntPtr NativeFieldInfoPtr_dropdown;

		// Token: 0x04006521 RID: 25889
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006522 RID: 25890
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04006523 RID: 25891
		private static readonly IntPtr NativeMethodInfoPtr_AddOption_Protected_Void_String_0;

		// Token: 0x04006524 RID: 25892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
