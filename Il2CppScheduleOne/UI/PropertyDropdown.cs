using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000660 RID: 1632
	public class PropertyDropdown : MonoBehaviour
	{
		// Token: 0x060091BA RID: 37306 RVA: 0x0025A05C File Offset: 0x0025825C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDropdown()
		{
			Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropertyDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr);
			PropertyDropdown.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "selectedProperty");
			PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "TMP_dropdown");
			PropertyDropdown.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "dropdown");
			PropertyDropdown.NativeFieldInfoPtr_intToProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "intToProperty");
			PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "onSelectionChanged");
			PropertyDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681359);
			PropertyDropdown.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681360);
			PropertyDropdown.NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681361);
			PropertyDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681362);
		}

		// Token: 0x060091BB RID: 37307 RVA: 0x0025A140 File Offset: 0x00258340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263333, XrefRangeEnd = 263403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x0025A17C File Offset: 0x0025837C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263403, XrefRangeEnd = 263432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertyAcquired(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091BD RID: 37309 RVA: 0x0025A1C0 File Offset: 0x002583C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263432, XrefRangeEnd = 263436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(int newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091BE RID: 37310 RVA: 0x0025A200 File Offset: 0x00258400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263436, XrefRangeEnd = 263444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091BF RID: 37311 RVA: 0x0004678E File Offset: 0x0004498E
		public PropertyDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x060091C0 RID: 37312 RVA: 0x0025A23C File Offset: 0x0025843C
		// (set) Token: 0x060091C1 RID: 37313 RVA: 0x00046797 File Offset: 0x00044997
		public unsafe Property selectedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_selectedProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x060091C2 RID: 37314 RVA: 0x0025A26C File Offset: 0x0025846C
		// (set) Token: 0x060091C3 RID: 37315 RVA: 0x000467B6 File Offset: 0x000449B6
		public unsafe TMP_Dropdown TMP_dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x060091C4 RID: 37316 RVA: 0x0025A29C File Offset: 0x0025849C
		// (set) Token: 0x060091C5 RID: 37317 RVA: 0x000467D5 File Offset: 0x000449D5
		public unsafe Dropdown dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x060091C6 RID: 37318 RVA: 0x0025A2CC File Offset: 0x002584CC
		// (set) Token: 0x060091C7 RID: 37319 RVA: 0x000467F4 File Offset: 0x000449F4
		public unsafe Dictionary<int, Property> intToProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_intToProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_intToProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x060091C8 RID: 37320 RVA: 0x0025A2FC File Offset: 0x002584FC
		// (set) Token: 0x060091C9 RID: 37321 RVA: 0x00046813 File Offset: 0x00044A13
		public unsafe Action onSelectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006278 RID: 25208
		private static readonly IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x04006279 RID: 25209
		private static readonly IntPtr NativeFieldInfoPtr_TMP_dropdown;

		// Token: 0x0400627A RID: 25210
		private static readonly IntPtr NativeFieldInfoPtr_dropdown;

		// Token: 0x0400627B RID: 25211
		private static readonly IntPtr NativeFieldInfoPtr_intToProperty;

		// Token: 0x0400627C RID: 25212
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x0400627D RID: 25213
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400627E RID: 25214
		private static readonly IntPtr NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0;

		// Token: 0x0400627F RID: 25215
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0;

		// Token: 0x04006280 RID: 25216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
