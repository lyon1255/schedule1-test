using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000601 RID: 1537
	public class AvatarWeapon : AvatarEquippable
	{
		// Token: 0x06008784 RID: 34692 RVA: 0x0023C0A4 File Offset: 0x0023A2A4
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarWeapon()
		{
			Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr);
			AvatarWeapon.NativeFieldInfoPtr_MinUseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "MinUseRange");
			AvatarWeapon.NativeFieldInfoPtr_MaxUseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "MaxUseRange");
			AvatarWeapon.NativeFieldInfoPtr_CooldownDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "CooldownDuration");
			AvatarWeapon.NativeFieldInfoPtr_EquipClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "EquipClips");
			AvatarWeapon.NativeFieldInfoPtr_EquipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "EquipSound");
			AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "<LastUseTime>k__BackingField");
			AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "onSuccessfulHit");
			AvatarWeapon.NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680204);
			AvatarWeapon.NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680205);
			AvatarWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680206);
			AvatarWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680207);
			AvatarWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680208);
			AvatarWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680209);
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x06008785 RID: 34693 RVA: 0x0023C1D8 File Offset: 0x0023A3D8
		// (set) Token: 0x06008786 RID: 34694 RVA: 0x0023C214 File Offset: 0x0023A414
		public unsafe float LastUseTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x0023C254 File Offset: 0x0023A454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251475, XrefRangeEnd = 251482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x0023C2A4 File Offset: 0x0023A4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251482, XrefRangeEnd = 251483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008789 RID: 34697 RVA: 0x0023C2E0 File Offset: 0x0023A4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251483, XrefRangeEnd = 251484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsReadyToAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600878A RID: 34698 RVA: 0x0023C328 File Offset: 0x0023A528
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 251492, RefRangeEnd = 251496, XrefRangeStart = 251484, XrefRangeEnd = 251492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600878B RID: 34699 RVA: 0x0004089B File Offset: 0x0003EA9B
		public AvatarWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600878C RID: 34700 RVA: 0x0023C364 File Offset: 0x0023A564
		// (set) Token: 0x0600878D RID: 34701 RVA: 0x000408A4 File Offset: 0x0003EAA4
		public unsafe float MinUseRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MinUseRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MinUseRange)) = value;
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x0600878E RID: 34702 RVA: 0x0023C38C File Offset: 0x0023A58C
		// (set) Token: 0x0600878F RID: 34703 RVA: 0x000408BF File Offset: 0x0003EABF
		public unsafe float MaxUseRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MaxUseRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MaxUseRange)) = value;
			}
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x06008790 RID: 34704 RVA: 0x0023C3B4 File Offset: 0x0023A5B4
		// (set) Token: 0x06008791 RID: 34705 RVA: 0x000408DA File Offset: 0x0003EADA
		public unsafe float CooldownDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_CooldownDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_CooldownDuration)) = value;
			}
		}

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x06008792 RID: 34706 RVA: 0x0023C3DC File Offset: 0x0023A5DC
		// (set) Token: 0x06008793 RID: 34707 RVA: 0x000408F5 File Offset: 0x0003EAF5
		public unsafe Il2CppReferenceArray<AudioClip> EquipClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x06008794 RID: 34708 RVA: 0x0023C40C File Offset: 0x0023A60C
		// (set) Token: 0x06008795 RID: 34709 RVA: 0x00040914 File Offset: 0x0003EB14
		public unsafe AudioSourceController EquipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x06008796 RID: 34710 RVA: 0x0023C43C File Offset: 0x0023A63C
		// (set) Token: 0x06008797 RID: 34711 RVA: 0x00040933 File Offset: 0x0003EB33
		public unsafe float _LastUseTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x06008798 RID: 34712 RVA: 0x0023C464 File Offset: 0x0023A664
		// (set) Token: 0x06008799 RID: 34713 RVA: 0x0004094E File Offset: 0x0003EB4E
		public unsafe UnityEvent onSuccessfulHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C2A RID: 23594
		private static readonly IntPtr NativeFieldInfoPtr_MinUseRange;

		// Token: 0x04005C2B RID: 23595
		private static readonly IntPtr NativeFieldInfoPtr_MaxUseRange;

		// Token: 0x04005C2C RID: 23596
		private static readonly IntPtr NativeFieldInfoPtr_CooldownDuration;

		// Token: 0x04005C2D RID: 23597
		private static readonly IntPtr NativeFieldInfoPtr_EquipClips;

		// Token: 0x04005C2E RID: 23598
		private static readonly IntPtr NativeFieldInfoPtr_EquipSound;

		// Token: 0x04005C2F RID: 23599
		private static readonly IntPtr NativeFieldInfoPtr__LastUseTime_k__BackingField;

		// Token: 0x04005C30 RID: 23600
		private static readonly IntPtr NativeFieldInfoPtr_onSuccessfulHit;

		// Token: 0x04005C31 RID: 23601
		private static readonly IntPtr NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0;

		// Token: 0x04005C32 RID: 23602
		private static readonly IntPtr NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0;

		// Token: 0x04005C33 RID: 23603
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04005C34 RID: 23604
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0;

		// Token: 0x04005C35 RID: 23605
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0;

		// Token: 0x04005C36 RID: 23606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
