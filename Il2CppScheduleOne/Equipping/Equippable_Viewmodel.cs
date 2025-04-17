using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C7 RID: 1479
	public class Equippable_Viewmodel : Equippable_StorableItem
	{
		// Token: 0x060081FA RID: 33274 RVA: 0x00229CC8 File Offset: 0x00227EC8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Viewmodel()
		{
			Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Viewmodel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr);
			Equippable_Viewmodel.NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localPosition");
			Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localEulerAngles");
			Equippable_Viewmodel.NativeFieldInfoPtr_localScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localScale");
			Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "AvatarEquippable");
			Equippable_Viewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679562);
			Equippable_Viewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679563);
			Equippable_Viewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679564);
			Equippable_Viewmodel.NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679565);
			Equippable_Viewmodel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679566);
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x00229DAC File Offset: 0x00227FAC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 245631, RefRangeEnd = 245643, XrefRangeStart = 245603, XrefRangeEnd = 245631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x00229DFC File Offset: 0x00227FFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 245644, RefRangeEnd = 245649, XrefRangeStart = 245643, XrefRangeEnd = 245644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x00229E38 File Offset: 0x00228038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245649, XrefRangeEnd = 245658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayEquipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x00229E74 File Offset: 0x00228074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245658, XrefRangeEnd = 245669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayUnequipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x00229EB0 File Offset: 0x002280B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244274, RefRangeEnd = 244282, XrefRangeStart = 244274, XrefRangeEnd = 244282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Viewmodel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Viewmodel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x0003DCC5 File Offset: 0x0003BEC5
		public Equippable_Viewmodel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x06008201 RID: 33281 RVA: 0x00229EEC File Offset: 0x002280EC
		// (set) Token: 0x06008202 RID: 33282 RVA: 0x0003DCCE File Offset: 0x0003BECE
		public unsafe Vector3 localPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localPosition)) = value;
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x06008203 RID: 33283 RVA: 0x00229F14 File Offset: 0x00228114
		// (set) Token: 0x06008204 RID: 33284 RVA: 0x0003DCE9 File Offset: 0x0003BEE9
		public unsafe Vector3 localEulerAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles)) = value;
			}
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x06008205 RID: 33285 RVA: 0x00229F3C File Offset: 0x0022813C
		// (set) Token: 0x06008206 RID: 33286 RVA: 0x0003DD04 File Offset: 0x0003BF04
		public unsafe Vector3 localScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localScale)) = value;
			}
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x06008207 RID: 33287 RVA: 0x00229F64 File Offset: 0x00228164
		// (set) Token: 0x06008208 RID: 33288 RVA: 0x0003DD1F File Offset: 0x0003BF1F
		public unsafe AvatarEquippable AvatarEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400586E RID: 22638
		private static readonly IntPtr NativeFieldInfoPtr_localPosition;

		// Token: 0x0400586F RID: 22639
		private static readonly IntPtr NativeFieldInfoPtr_localEulerAngles;

		// Token: 0x04005870 RID: 22640
		private static readonly IntPtr NativeFieldInfoPtr_localScale;

		// Token: 0x04005871 RID: 22641
		private static readonly IntPtr NativeFieldInfoPtr_AvatarEquippable;

		// Token: 0x04005872 RID: 22642
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005873 RID: 22643
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005874 RID: 22644
		private static readonly IntPtr NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x04005875 RID: 22645
		private static readonly IntPtr NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x04005876 RID: 22646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
