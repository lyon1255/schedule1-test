using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BD RID: 1469
	public class Equippable : MonoBehaviour
	{
		// Token: 0x060080DE RID: 32990 RVA: 0x00226998 File Offset: 0x00224B98
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable()
		{
			Il2CppClassPointerStore<Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable>.NativeClassPtr);
			Equippable.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "itemInstance");
			Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "CanInteractWhenEquipped");
			Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "CanPickUpWhenEquipped");
			Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679455);
			Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679456);
			Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679457);
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x00226A40 File Offset: 0x00224C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244585, XrefRangeEnd = 244592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x00226A90 File Offset: 0x00224C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244592, XrefRangeEnd = 244603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x00226ACC File Offset: 0x00224CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244603, XrefRangeEnd = 244604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x0003D28E File Offset: 0x0003B48E
		public Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x060080E3 RID: 32995 RVA: 0x00226B08 File Offset: 0x00224D08
		// (set) Token: 0x060080E4 RID: 32996 RVA: 0x0003D297 File Offset: 0x0003B497
		public unsafe ItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x060080E5 RID: 32997 RVA: 0x00226B38 File Offset: 0x00224D38
		// (set) Token: 0x060080E6 RID: 32998 RVA: 0x0003D2B6 File Offset: 0x0003B4B6
		public unsafe bool CanInteractWhenEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped)) = value;
			}
		}

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x060080E7 RID: 32999 RVA: 0x00226B60 File Offset: 0x00224D60
		// (set) Token: 0x060080E8 RID: 33000 RVA: 0x0003D2D1 File Offset: 0x0003B4D1
		public unsafe bool CanPickUpWhenEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped)) = value;
			}
		}

		// Token: 0x040057C0 RID: 22464
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x040057C1 RID: 22465
		private static readonly IntPtr NativeFieldInfoPtr_CanInteractWhenEquipped;

		// Token: 0x040057C2 RID: 22466
		private static readonly IntPtr NativeFieldInfoPtr_CanPickUpWhenEquipped;

		// Token: 0x040057C3 RID: 22467
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x040057C4 RID: 22468
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x040057C5 RID: 22469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
