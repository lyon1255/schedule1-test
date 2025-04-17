using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000694 RID: 1684
	public class SettingsToggle : MonoBehaviour
	{
		// Token: 0x06009616 RID: 38422 RVA: 0x0026744C File Offset: 0x0026564C
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsToggle()
		{
			Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr);
			SettingsToggle.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, "toggle");
			SettingsToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100681852);
			SettingsToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100681853);
			SettingsToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100681854);
		}

		// Token: 0x06009617 RID: 38423 RVA: 0x002674CC File Offset: 0x002656CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269171, XrefRangeEnd = 269183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009618 RID: 38424 RVA: 0x00267508 File Offset: 0x00265708
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009619 RID: 38425 RVA: 0x00267554 File Offset: 0x00265754
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600961A RID: 38426 RVA: 0x00048DEC File Offset: 0x00046FEC
		public SettingsToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0600961B RID: 38427 RVA: 0x00267590 File Offset: 0x00265790
		// (set) Token: 0x0600961C RID: 38428 RVA: 0x00048DF5 File Offset: 0x00046FF5
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsToggle.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsToggle.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400652F RID: 25903
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x04006530 RID: 25904
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006531 RID: 25905
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04006532 RID: 25906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
