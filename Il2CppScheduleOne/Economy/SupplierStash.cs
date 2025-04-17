using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200041C RID: 1052
	public class SupplierStash : MonoBehaviour
	{
		// Token: 0x06005C56 RID: 23638 RVA: 0x001AB728 File Offset: 0x001A9928
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierStash()
		{
			Il2CppClassPointerStore<SupplierStash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierStash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr);
			SupplierStash.NativeFieldInfoPtr_locationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "locationDescription");
			SupplierStash.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Supplier");
			SupplierStash.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Storage");
			SupplierStash.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "IntObj");
			SupplierStash.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Light");
			SupplierStash.NativeFieldInfoPtr_StashPoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "StashPoI");
			SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "<CashAmount>k__BackingField");
			SupplierStash.NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675078);
			SupplierStash.NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675079);
			SupplierStash.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675080);
			SupplierStash.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675081);
			SupplierStash.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675082);
			SupplierStash.NativeMethodInfoPtr_RecalculateCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675083);
			SupplierStash.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675084);
			SupplierStash.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675085);
			SupplierStash.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675086);
			SupplierStash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675087);
			SupplierStash.NativeMethodInfoPtr__Awake_b__10_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675088);
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06005C57 RID: 23639 RVA: 0x001AB8C0 File Offset: 0x001A9AC0
		// (set) Token: 0x06005C58 RID: 23640 RVA: 0x001AB8FC File Offset: 0x001A9AFC
		public unsafe float CashAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005C59 RID: 23641 RVA: 0x001AB93C File Offset: 0x001A9B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194677, XrefRangeEnd = 194738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SupplierStash.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C5A RID: 23642 RVA: 0x001AB978 File Offset: 0x001A9B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194738, XrefRangeEnd = 194753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SupplierStash.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x001AB9B4 File Offset: 0x001A9BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194753, XrefRangeEnd = 194764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SupplierUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x001AB9E8 File Offset: 0x001A9BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194778, RefRangeEnd = 194779, XrefRangeStart = 194764, XrefRangeEnd = 194778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_RecalculateCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x001ABA1C File Offset: 0x001A9C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194779, XrefRangeEnd = 194799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x001ABA50 File Offset: 0x001A9C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194814, RefRangeEnd = 194815, XrefRangeStart = 194799, XrefRangeEnd = 194814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCash(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x001ABA90 File Offset: 0x001A9C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194815, XrefRangeEnd = 194816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDeadDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x001ABAC4 File Offset: 0x001A9CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194816, XrefRangeEnd = 194821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierStash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x001ABB00 File Offset: 0x001A9D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__10_0(NPCRelationData.EUnlockType type, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr__Awake_b__10_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x0002B850 File Offset: 0x00029A50
		public SupplierStash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06005C63 RID: 23651 RVA: 0x001ABB4C File Offset: 0x001A9D4C
		// (set) Token: 0x06005C64 RID: 23652 RVA: 0x0002B859 File Offset: 0x00029A59
		public unsafe string locationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_locationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_locationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06005C65 RID: 23653 RVA: 0x001ABB74 File Offset: 0x001A9D74
		// (set) Token: 0x06005C66 RID: 23654 RVA: 0x0002B878 File Offset: 0x00029A78
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06005C67 RID: 23655 RVA: 0x001ABBA4 File Offset: 0x001A9DA4
		// (set) Token: 0x06005C68 RID: 23656 RVA: 0x0002B897 File Offset: 0x00029A97
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06005C69 RID: 23657 RVA: 0x001ABBD4 File Offset: 0x001A9DD4
		// (set) Token: 0x06005C6A RID: 23658 RVA: 0x0002B8B6 File Offset: 0x00029AB6
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06005C6B RID: 23659 RVA: 0x001ABC04 File Offset: 0x001A9E04
		// (set) Token: 0x06005C6C RID: 23660 RVA: 0x0002B8D5 File Offset: 0x00029AD5
		public unsafe OptimizedLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06005C6D RID: 23661 RVA: 0x001ABC34 File Offset: 0x001A9E34
		// (set) Token: 0x06005C6E RID: 23662 RVA: 0x0002B8F4 File Offset: 0x00029AF4
		public unsafe POI StashPoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_StashPoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_StashPoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06005C6F RID: 23663 RVA: 0x001ABC64 File Offset: 0x001A9E64
		// (set) Token: 0x06005C70 RID: 23664 RVA: 0x0002B913 File Offset: 0x00029B13
		public unsafe float _CashAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x04003F2B RID: 16171
		private static readonly IntPtr NativeFieldInfoPtr_locationDescription;

		// Token: 0x04003F2C RID: 16172
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x04003F2D RID: 16173
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04003F2E RID: 16174
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04003F2F RID: 16175
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04003F30 RID: 16176
		private static readonly IntPtr NativeFieldInfoPtr_StashPoI;

		// Token: 0x04003F31 RID: 16177
		private static readonly IntPtr NativeFieldInfoPtr__CashAmount_k__BackingField;

		// Token: 0x04003F32 RID: 16178
		private static readonly IntPtr NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0;

		// Token: 0x04003F33 RID: 16179
		private static readonly IntPtr NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0;

		// Token: 0x04003F34 RID: 16180
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003F35 RID: 16181
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003F36 RID: 16182
		private static readonly IntPtr NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0;

		// Token: 0x04003F37 RID: 16183
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateCash_Private_Void_0;

		// Token: 0x04003F38 RID: 16184
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04003F39 RID: 16185
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0;

		// Token: 0x04003F3A RID: 16186
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0;

		// Token: 0x04003F3B RID: 16187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F3C RID: 16188
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__10_0_Private_Void_EUnlockType_Boolean_0;
	}
}
