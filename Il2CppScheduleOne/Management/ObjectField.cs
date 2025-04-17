using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000395 RID: 917
	public class ObjectField : ConfigField
	{
		// Token: 0x060047FE RID: 18430 RVA: 0x001607EC File Offset: 0x0015E9EC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectField()
		{
			Il2CppClassPointerStore<ObjectField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ObjectField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectField>.NativeClassPtr);
			ObjectField.NativeFieldInfoPtr_SelectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "SelectedObject");
			ObjectField.NativeFieldInfoPtr_onObjectChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "onObjectChanged");
			ObjectField.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "objectFilter");
			ObjectField.NativeFieldInfoPtr_TypeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "TypeRequirements");
			ObjectField.NativeFieldInfoPtr_DrawTransitLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "DrawTransitLine");
			ObjectField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672200);
			ObjectField.NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672201);
			ObjectField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672202);
			ObjectField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672203);
			ObjectField.NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672204);
			ObjectField.NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672205);
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x001608F8 File Offset: 0x0015EAF8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 161478, RefRangeEnd = 161491, XrefRangeStart = 161463, XrefRangeEnd = 161478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x00160944 File Offset: 0x0015EB44
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 161518, RefRangeEnd = 161526, XrefRangeStart = 161491, XrefRangeEnd = 161518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObject(BuildableItem obj, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x00160994 File Offset: 0x0015EB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161526, XrefRangeEnd = 161530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x001609DC File Offset: 0x0015EBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161530, XrefRangeEnd = 161531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectedObjectDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x00160A10 File Offset: 0x0015EC10
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 161544, RefRangeEnd = 161557, XrefRangeStart = 161531, XrefRangeEnd = 161544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ObjectFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x00160A54 File Offset: 0x0015EC54
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 161569, RefRangeEnd = 161582, XrefRangeStart = 161557, XrefRangeEnd = 161569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr3) : null;
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x00022CF2 File Offset: 0x00020EF2
		public ObjectField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06004806 RID: 18438 RVA: 0x00160A94 File Offset: 0x0015EC94
		// (set) Token: 0x06004807 RID: 18439 RVA: 0x00022CFB File Offset: 0x00020EFB
		public unsafe BuildableItem SelectedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_SelectedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_SelectedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06004808 RID: 18440 RVA: 0x00160AC4 File Offset: 0x0015ECC4
		// (set) Token: 0x06004809 RID: 18441 RVA: 0x00022D1A File Offset: 0x00020F1A
		public unsafe UnityEvent<BuildableItem> onObjectChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_onObjectChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_onObjectChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x0600480A RID: 18442 RVA: 0x00160AF4 File Offset: 0x0015ECF4
		// (set) Token: 0x0600480B RID: 18443 RVA: 0x00022D39 File Offset: 0x00020F39
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x0600480C RID: 18444 RVA: 0x00160B24 File Offset: 0x0015ED24
		// (set) Token: 0x0600480D RID: 18445 RVA: 0x00022D58 File Offset: 0x00020F58
		public unsafe List<Type> TypeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_TypeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_TypeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x0600480E RID: 18446 RVA: 0x00160B54 File Offset: 0x0015ED54
		// (set) Token: 0x0600480F RID: 18447 RVA: 0x00022D77 File Offset: 0x00020F77
		public unsafe bool DrawTransitLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_DrawTransitLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_DrawTransitLine)) = value;
			}
		}

		// Token: 0x04003087 RID: 12423
		private static readonly IntPtr NativeFieldInfoPtr_SelectedObject;

		// Token: 0x04003088 RID: 12424
		private static readonly IntPtr NativeFieldInfoPtr_onObjectChanged;

		// Token: 0x04003089 RID: 12425
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x0400308A RID: 12426
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirements;

		// Token: 0x0400308B RID: 12427
		private static readonly IntPtr NativeFieldInfoPtr_DrawTransitLine;

		// Token: 0x0400308C RID: 12428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400308D RID: 12429
		private static readonly IntPtr NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0;

		// Token: 0x0400308E RID: 12430
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x0400308F RID: 12431
		private static readonly IntPtr NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0;

		// Token: 0x04003090 RID: 12432
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0;

		// Token: 0x04003091 RID: 12433
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0;
	}
}
