using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.UI.Items;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E2 RID: 1506
	[Serializable]
	public class ItemDefinition : ScriptableObject
	{
		// Token: 0x0600837D RID: 33661 RVA: 0x0022F35C File Offset: 0x0022D55C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDefinition()
		{
			Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr);
			ItemDefinition.NativeFieldInfoPtr_DEFAULT_STACK_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "DEFAULT_STACK_LIMIT");
			ItemDefinition.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Name");
			ItemDefinition.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Description");
			ItemDefinition.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "ID");
			ItemDefinition.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Icon");
			ItemDefinition.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Category");
			ItemDefinition.NativeFieldInfoPtr_Keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Keywords");
			ItemDefinition.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "AvailableInDemo");
			ItemDefinition.NativeFieldInfoPtr_LabelDisplayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "LabelDisplayColor");
			ItemDefinition.NativeFieldInfoPtr_StackLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "StackLimit");
			ItemDefinition.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Equippable");
			ItemDefinition.NativeFieldInfoPtr_CustomItemUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "CustomItemUI");
			ItemDefinition.NativeFieldInfoPtr_CustomInfoContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "CustomInfoContent");
			ItemDefinition.NativeFieldInfoPtr_legalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "legalStatus");
			ItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, 100679748);
			ItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, 100679749);
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x0022F4CC File Offset: 0x0022D6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247196, XrefRangeEnd = 247202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x0022F524 File Offset: 0x0022D724
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247203, RefRangeEnd = 247205, XrefRangeStart = 247202, XrefRangeEnd = 247203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x0003E6B9 File Offset: 0x0003C8B9
		public ItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x06008381 RID: 33665 RVA: 0x0022F560 File Offset: 0x0022D760
		// (set) Token: 0x06008382 RID: 33666 RVA: 0x0003E6C2 File Offset: 0x0003C8C2
		public unsafe static int DEFAULT_STACK_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ItemDefinition.NativeFieldInfoPtr_DEFAULT_STACK_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemDefinition.NativeFieldInfoPtr_DEFAULT_STACK_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x06008383 RID: 33667 RVA: 0x0022F57C File Offset: 0x0022D77C
		// (set) Token: 0x06008384 RID: 33668 RVA: 0x0003E6D0 File Offset: 0x0003C8D0
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x06008385 RID: 33669 RVA: 0x0022F5A4 File Offset: 0x0022D7A4
		// (set) Token: 0x06008386 RID: 33670 RVA: 0x0003E6EF File Offset: 0x0003C8EF
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x06008387 RID: 33671 RVA: 0x0022F5CC File Offset: 0x0022D7CC
		// (set) Token: 0x06008388 RID: 33672 RVA: 0x0003E70E File Offset: 0x0003C90E
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x06008389 RID: 33673 RVA: 0x0022F5F4 File Offset: 0x0022D7F4
		// (set) Token: 0x0600838A RID: 33674 RVA: 0x0003E72D File Offset: 0x0003C92D
		public unsafe Sprite Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x0600838B RID: 33675 RVA: 0x0022F624 File Offset: 0x0022D824
		// (set) Token: 0x0600838C RID: 33676 RVA: 0x0003E74C File Offset: 0x0003C94C
		public unsafe EItemCategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x0600838D RID: 33677 RVA: 0x0022F64C File Offset: 0x0022D84C
		// (set) Token: 0x0600838E RID: 33678 RVA: 0x0003E767 File Offset: 0x0003C967
		public unsafe Il2CppStringArray Keywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Keywords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Keywords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x0600838F RID: 33679 RVA: 0x0022F67C File Offset: 0x0022D87C
		// (set) Token: 0x06008390 RID: 33680 RVA: 0x0003E786 File Offset: 0x0003C986
		public unsafe bool AvailableInDemo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x06008391 RID: 33681 RVA: 0x0022F6A4 File Offset: 0x0022D8A4
		// (set) Token: 0x06008392 RID: 33682 RVA: 0x0003E7A1 File Offset: 0x0003C9A1
		public unsafe Color LabelDisplayColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_LabelDisplayColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_LabelDisplayColor)) = value;
			}
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x06008393 RID: 33683 RVA: 0x0022F6CC File Offset: 0x0022D8CC
		// (set) Token: 0x06008394 RID: 33684 RVA: 0x0003E7BC File Offset: 0x0003C9BC
		public unsafe int StackLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_StackLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_StackLimit)) = value;
			}
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x06008395 RID: 33685 RVA: 0x0022F6F4 File Offset: 0x0022D8F4
		// (set) Token: 0x06008396 RID: 33686 RVA: 0x0003E7D7 File Offset: 0x0003C9D7
		public unsafe Equippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x06008397 RID: 33687 RVA: 0x0022F724 File Offset: 0x0022D924
		// (set) Token: 0x06008398 RID: 33688 RVA: 0x0003E7F6 File Offset: 0x0003C9F6
		public unsafe ItemUI CustomItemUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomItemUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomItemUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x06008399 RID: 33689 RVA: 0x0022F754 File Offset: 0x0022D954
		// (set) Token: 0x0600839A RID: 33690 RVA: 0x0003E815 File Offset: 0x0003CA15
		public unsafe ItemInfoContent CustomInfoContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomInfoContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomInfoContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x0600839B RID: 33691 RVA: 0x0022F784 File Offset: 0x0022D984
		// (set) Token: 0x0600839C RID: 33692 RVA: 0x0003E834 File Offset: 0x0003CA34
		public unsafe ELegalStatus legalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_legalStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_legalStatus)) = value;
			}
		}

		// Token: 0x04005982 RID: 22914
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_STACK_LIMIT;

		// Token: 0x04005983 RID: 22915
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005984 RID: 22916
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04005985 RID: 22917
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04005986 RID: 22918
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04005987 RID: 22919
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04005988 RID: 22920
		private static readonly IntPtr NativeFieldInfoPtr_Keywords;

		// Token: 0x04005989 RID: 22921
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x0400598A RID: 22922
		private static readonly IntPtr NativeFieldInfoPtr_LabelDisplayColor;

		// Token: 0x0400598B RID: 22923
		private static readonly IntPtr NativeFieldInfoPtr_StackLimit;

		// Token: 0x0400598C RID: 22924
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x0400598D RID: 22925
		private static readonly IntPtr NativeFieldInfoPtr_CustomItemUI;

		// Token: 0x0400598E RID: 22926
		private static readonly IntPtr NativeFieldInfoPtr_CustomInfoContent;

		// Token: 0x0400598F RID: 22927
		private static readonly IntPtr NativeFieldInfoPtr_legalStatus;

		// Token: 0x04005990 RID: 22928
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x04005991 RID: 22929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
