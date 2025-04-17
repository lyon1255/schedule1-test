using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BF RID: 1471
	public class Equippable_AvatarViewmodel : Equippable_Viewmodel
	{
		// Token: 0x060080F1 RID: 33009 RVA: 0x00226D9C File Offset: 0x00224F9C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_AvatarViewmodel()
		{
			Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_AvatarViewmodel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr);
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "AnimatorController");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "ViewmodelAvatarOffset");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "EquipTime");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "EquipTrigger");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "timeEquipped");
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679462);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679463);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679464);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679465);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679466);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679467);
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x060080F2 RID: 33010 RVA: 0x00226EA8 File Offset: 0x002250A8
		public unsafe bool equipAnimDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_AvatarViewmodel.NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x00226EE4 File Offset: 0x002250E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244661, RefRangeEnd = 244663, XrefRangeStart = 244637, XrefRangeEnd = 244661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080F4 RID: 33012 RVA: 0x00226F34 File Offset: 0x00225134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244670, RefRangeEnd = 244672, XrefRangeStart = 244663, XrefRangeEnd = 244670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080F5 RID: 33013 RVA: 0x00226F70 File Offset: 0x00225170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244672, XrefRangeEnd = 244689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayEquipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080F6 RID: 33014 RVA: 0x00226FAC File Offset: 0x002251AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244689, XrefRangeEnd = 244690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080F7 RID: 33015 RVA: 0x00226FE8 File Offset: 0x002251E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 244699, RefRangeEnd = 244702, XrefRangeStart = 244690, XrefRangeEnd = 244699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_AvatarViewmodel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_AvatarViewmodel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080F8 RID: 33016 RVA: 0x0003D314 File Offset: 0x0003B514
		public Equippable_AvatarViewmodel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x060080F9 RID: 33017 RVA: 0x00227024 File Offset: 0x00225224
		// (set) Token: 0x060080FA RID: 33018 RVA: 0x0003D31D File Offset: 0x0003B51D
		public unsafe RuntimeAnimatorController AnimatorController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x060080FB RID: 33019 RVA: 0x00227054 File Offset: 0x00225254
		// (set) Token: 0x060080FC RID: 33020 RVA: 0x0003D33C File Offset: 0x0003B53C
		public unsafe Vector3 ViewmodelAvatarOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset)) = value;
			}
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x060080FD RID: 33021 RVA: 0x0022707C File Offset: 0x0022527C
		// (set) Token: 0x060080FE RID: 33022 RVA: 0x0003D357 File Offset: 0x0003B557
		public unsafe float EquipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime)) = value;
			}
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x060080FF RID: 33023 RVA: 0x002270A4 File Offset: 0x002252A4
		// (set) Token: 0x06008100 RID: 33024 RVA: 0x0003D372 File Offset: 0x0003B572
		public unsafe string EquipTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x06008101 RID: 33025 RVA: 0x002270CC File Offset: 0x002252CC
		// (set) Token: 0x06008102 RID: 33026 RVA: 0x0003D391 File Offset: 0x0003B591
		public unsafe float timeEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped)) = value;
			}
		}

		// Token: 0x040057CB RID: 22475
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorController;

		// Token: 0x040057CC RID: 22476
		private static readonly IntPtr NativeFieldInfoPtr_ViewmodelAvatarOffset;

		// Token: 0x040057CD RID: 22477
		private static readonly IntPtr NativeFieldInfoPtr_EquipTime;

		// Token: 0x040057CE RID: 22478
		private static readonly IntPtr NativeFieldInfoPtr_EquipTrigger;

		// Token: 0x040057CF RID: 22479
		private static readonly IntPtr NativeFieldInfoPtr_timeEquipped;

		// Token: 0x040057D0 RID: 22480
		private static readonly IntPtr NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0;

		// Token: 0x040057D1 RID: 22481
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057D2 RID: 22482
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057D3 RID: 22483
		private static readonly IntPtr NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0;

		// Token: 0x040057D4 RID: 22484
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057D5 RID: 22485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
