using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E4 RID: 1508
	[Serializable]
	public class ItemInstance : Il2CppSystem.Object
	{
		// Token: 0x060083A5 RID: 33701 RVA: 0x0022F8F4 File Offset: 0x0022DAF4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInstance()
		{
			Il2CppClassPointerStore<ItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr);
			ItemInstance.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "definition");
			ItemInstance.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "ID");
			ItemInstance.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "Quantity");
			ItemInstance.NativeFieldInfoPtr_onDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "onDataChanged");
			ItemInstance.NativeFieldInfoPtr_requestClearSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "requestClearSlot");
			ItemInstance.NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679752);
			ItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679753);
			ItemInstance.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679754);
			ItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679755);
			ItemInstance.NativeMethodInfoPtr_get_Category_Public_Virtual_New_get_EItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679756);
			ItemInstance.NativeMethodInfoPtr_get_StackLimit_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679757);
			ItemInstance.NativeMethodInfoPtr_get_LabelDisplayColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679758);
			ItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679759);
			ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679760);
			ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679761);
			ItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679762);
			ItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679763);
			ItemInstance.NativeMethodInfoPtr_IsValidInstance_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679764);
			ItemInstance.NativeMethodInfoPtr_InvokeDataChange_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679765);
			ItemInstance.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679766);
			ItemInstance.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679767);
			ItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679768);
			ItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679769);
			ItemInstance.NativeMethodInfoPtr_RequestClearSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679770);
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x060083A6 RID: 33702 RVA: 0x0022FB04 File Offset: 0x0022DD04
		public unsafe ItemDefinition Definition
		{
			[CallerCount(134)]
			[CachedScanResults(RefRangeStart = 247227, RefRangeEnd = 247361, XrefRangeStart = 247211, XrefRangeEnd = 247227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x060083A7 RID: 33703 RVA: 0x0022FB44 File Offset: 0x0022DD44
		public unsafe virtual string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 247362, RefRangeEnd = 247364, XrefRangeStart = 247361, XrefRangeEnd = 247362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x060083A8 RID: 33704 RVA: 0x0022FB88 File Offset: 0x0022DD88
		public unsafe virtual string Description
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247364, XrefRangeEnd = 247365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x060083A9 RID: 33705 RVA: 0x0022FBCC File Offset: 0x0022DDCC
		public unsafe virtual Sprite Icon
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 247366, RefRangeEnd = 247368, XrefRangeStart = 247365, XrefRangeEnd = 247366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x060083AA RID: 33706 RVA: 0x0022FC18 File Offset: 0x0022DE18
		public unsafe virtual EItemCategory Category
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247368, XrefRangeEnd = 247369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Category_Public_Virtual_New_get_EItemCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x060083AB RID: 33707 RVA: 0x0022FC60 File Offset: 0x0022DE60
		public unsafe virtual int StackLimit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247369, XrefRangeEnd = 247370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_StackLimit_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x060083AC RID: 33708 RVA: 0x0022FCA8 File Offset: 0x0022DEA8
		public unsafe virtual Color LabelDisplayColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247370, XrefRangeEnd = 247371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_LabelDisplayColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x060083AD RID: 33709 RVA: 0x0022FCF0 File Offset: 0x0022DEF0
		public unsafe virtual Equippable Equippable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 247372, RefRangeEnd = 247374, XrefRangeStart = 247371, XrefRangeEnd = 247372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
			}
		}

		// Token: 0x060083AE RID: 33710 RVA: 0x0022FD3C File Offset: 0x0022DF3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247378, RefRangeEnd = 247379, XrefRangeStart = 247374, XrefRangeEnd = 247378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083AF RID: 33711 RVA: 0x0022FD78 File Offset: 0x0022DF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247386, RefRangeEnd = 247388, XrefRangeStart = 247379, XrefRangeEnd = 247386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083B0 RID: 33712 RVA: 0x0022FDD4 File Offset: 0x0022DFD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247389, RefRangeEnd = 247390, XrefRangeStart = 247388, XrefRangeEnd = 247389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkQuantities;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083B1 RID: 33713 RVA: 0x0022FE3C File Offset: 0x0022E03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247390, XrefRangeEnd = 247396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060083B2 RID: 33714 RVA: 0x0022FE94 File Offset: 0x0022E094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247396, XrefRangeEnd = 247404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_IsValidInstance_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x0022FEDC File Offset: 0x0022E0DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247404, RefRangeEnd = 247407, XrefRangeStart = 247404, XrefRangeEnd = 247404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeDataChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_InvokeDataChange_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x0022FF10 File Offset: 0x0022E110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247407, XrefRangeEnd = 247418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083B5 RID: 33717 RVA: 0x0022FF50 File Offset: 0x0022E150
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 247429, RefRangeEnd = 247439, XrefRangeStart = 247418, XrefRangeEnd = 247429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083B6 RID: 33718 RVA: 0x0022FF90 File Offset: 0x0022E190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247439, XrefRangeEnd = 247443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x0022FFDC File Offset: 0x0022E1DC
		[CallerCount(0)]
		public unsafe virtual float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083B8 RID: 33720 RVA: 0x00230024 File Offset: 0x0022E224
		[CallerCount(0)]
		public unsafe void RequestClearSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_RequestClearSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083B9 RID: 33721 RVA: 0x0003E892 File Offset: 0x0003CA92
		public ItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x060083BA RID: 33722 RVA: 0x00230058 File Offset: 0x0022E258
		// (set) Token: 0x060083BB RID: 33723 RVA: 0x0003E89B File Offset: 0x0003CA9B
		public unsafe ItemDefinition definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x060083BC RID: 33724 RVA: 0x00230088 File Offset: 0x0022E288
		// (set) Token: 0x060083BD RID: 33725 RVA: 0x0003E8BA File Offset: 0x0003CABA
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x060083BE RID: 33726 RVA: 0x002300B0 File Offset: 0x0022E2B0
		// (set) Token: 0x060083BF RID: 33727 RVA: 0x0003E8D9 File Offset: 0x0003CAD9
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x060083C0 RID: 33728 RVA: 0x002300D8 File Offset: 0x0022E2D8
		// (set) Token: 0x060083C1 RID: 33729 RVA: 0x0003E8F4 File Offset: 0x0003CAF4
		public unsafe Action onDataChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_onDataChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_onDataChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x060083C2 RID: 33730 RVA: 0x00230108 File Offset: 0x0022E308
		// (set) Token: 0x060083C3 RID: 33731 RVA: 0x0003E913 File Offset: 0x0003CB13
		public unsafe Action requestClearSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_requestClearSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_requestClearSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005996 RID: 22934
		private static readonly IntPtr NativeFieldInfoPtr_definition;

		// Token: 0x04005997 RID: 22935
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04005998 RID: 22936
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04005999 RID: 22937
		private static readonly IntPtr NativeFieldInfoPtr_onDataChanged;

		// Token: 0x0400599A RID: 22938
		private static readonly IntPtr NativeFieldInfoPtr_requestClearSlot;

		// Token: 0x0400599B RID: 22939
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0;

		// Token: 0x0400599C RID: 22940
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x0400599D RID: 22941
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0;

		// Token: 0x0400599E RID: 22942
		private static readonly IntPtr NativeMethodInfoPtr_get_Icon_Public_Virtual_New_get_Sprite_0;

		// Token: 0x0400599F RID: 22943
		private static readonly IntPtr NativeMethodInfoPtr_get_Category_Public_Virtual_New_get_EItemCategory_0;

		// Token: 0x040059A0 RID: 22944
		private static readonly IntPtr NativeMethodInfoPtr_get_StackLimit_Public_Virtual_New_get_Int32_0;

		// Token: 0x040059A1 RID: 22945
		private static readonly IntPtr NativeMethodInfoPtr_get_LabelDisplayColor_Public_Virtual_New_get_Color_0;

		// Token: 0x040059A2 RID: 22946
		private static readonly IntPtr NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0;

		// Token: 0x040059A3 RID: 22947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040059A4 RID: 22948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x040059A5 RID: 22949
		private static readonly IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0;

		// Token: 0x040059A6 RID: 22950
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x040059A7 RID: 22951
		private static readonly IntPtr NativeMethodInfoPtr_IsValidInstance_Public_Virtual_New_Boolean_0;

		// Token: 0x040059A8 RID: 22952
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDataChange_Protected_Void_0;

		// Token: 0x040059A9 RID: 22953
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0;

		// Token: 0x040059AA RID: 22954
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0;

		// Token: 0x040059AB RID: 22955
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0;

		// Token: 0x040059AC RID: 22956
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_New_Single_0;

		// Token: 0x040059AD RID: 22957
		private static readonly IntPtr NativeMethodInfoPtr_RequestClearSlot_Public_Void_0;
	}
}
