using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020005FF RID: 1535
	public class AvatarMeleeWeapon : AvatarWeapon
	{
		// Token: 0x06008738 RID: 34616 RVA: 0x0023B488 File Offset: 0x00239688
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarMeleeWeapon()
		{
			Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarMeleeWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr);
			AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "GruntChance");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackSound");
			AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "HitSound");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackRange");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackRadius");
			AvatarMeleeWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "Damage");
			AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "Attacks");
			AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "attackRoutine");
			AvatarMeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100680174);
			AvatarMeleeWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100680175);
			AvatarMeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100680176);
		}

		// Token: 0x06008739 RID: 34617 RVA: 0x0023B594 File Offset: 0x00239794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251327, XrefRangeEnd = 251339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarMeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600873A RID: 34618 RVA: 0x0023B5D0 File Offset: 0x002397D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251339, XrefRangeEnd = 251364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarMeleeWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600873B RID: 34619 RVA: 0x0023B60C File Offset: 0x0023980C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251364, XrefRangeEnd = 251365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarMeleeWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600873C RID: 34620 RVA: 0x0004056C File Offset: 0x0003E76C
		public AvatarMeleeWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x0600873D RID: 34621 RVA: 0x0023B648 File Offset: 0x00239848
		// (set) Token: 0x0600873E RID: 34622 RVA: 0x00040575 File Offset: 0x0003E775
		public unsafe static float GruntChance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance, (void*)(&value));
			}
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x0600873F RID: 34623 RVA: 0x0023B664 File Offset: 0x00239864
		// (set) Token: 0x06008740 RID: 34624 RVA: 0x00040583 File Offset: 0x0003E783
		public unsafe AudioSourceController AttackSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x06008741 RID: 34625 RVA: 0x0023B694 File Offset: 0x00239894
		// (set) Token: 0x06008742 RID: 34626 RVA: 0x000405A2 File Offset: 0x0003E7A2
		public unsafe AudioSourceController HitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x06008743 RID: 34627 RVA: 0x0023B6C4 File Offset: 0x002398C4
		// (set) Token: 0x06008744 RID: 34628 RVA: 0x000405C1 File Offset: 0x0003E7C1
		public unsafe float AttackRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange)) = value;
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x06008745 RID: 34629 RVA: 0x0023B6EC File Offset: 0x002398EC
		// (set) Token: 0x06008746 RID: 34630 RVA: 0x000405DC File Offset: 0x0003E7DC
		public unsafe float AttackRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius)) = value;
			}
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x06008747 RID: 34631 RVA: 0x0023B714 File Offset: 0x00239914
		// (set) Token: 0x06008748 RID: 34632 RVA: 0x000405F7 File Offset: 0x0003E7F7
		public unsafe float Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x06008749 RID: 34633 RVA: 0x0023B73C File Offset: 0x0023993C
		// (set) Token: 0x0600874A RID: 34634 RVA: 0x00040612 File Offset: 0x0003E812
		public unsafe Il2CppReferenceArray<AvatarMeleeWeapon.MeleeAttack> Attacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarMeleeWeapon.MeleeAttack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x0600874B RID: 34635 RVA: 0x0023B76C File Offset: 0x0023996C
		// (set) Token: 0x0600874C RID: 34636 RVA: 0x00040631 File Offset: 0x0003E831
		public unsafe Coroutine attackRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BFF RID: 23551
		private static readonly IntPtr NativeFieldInfoPtr_GruntChance;

		// Token: 0x04005C00 RID: 23552
		private static readonly IntPtr NativeFieldInfoPtr_AttackSound;

		// Token: 0x04005C01 RID: 23553
		private static readonly IntPtr NativeFieldInfoPtr_HitSound;

		// Token: 0x04005C02 RID: 23554
		private static readonly IntPtr NativeFieldInfoPtr_AttackRange;

		// Token: 0x04005C03 RID: 23555
		private static readonly IntPtr NativeFieldInfoPtr_AttackRadius;

		// Token: 0x04005C04 RID: 23556
		private static readonly IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x04005C05 RID: 23557
		private static readonly IntPtr NativeFieldInfoPtr_Attacks;

		// Token: 0x04005C06 RID: 23558
		private static readonly IntPtr NativeFieldInfoPtr_attackRoutine;

		// Token: 0x04005C07 RID: 23559
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005C08 RID: 23560
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Public_Virtual_Void_0;

		// Token: 0x04005C09 RID: 23561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF6 RID: 2806
		[Serializable]
		public class MeleeAttack : Il2CppSystem.Object
		{
			// Token: 0x0600D5C2 RID: 54722 RVA: 0x0032ECD0 File Offset: 0x0032CED0
			// Note: this type is marked as 'beforefieldinit'.
			static MeleeAttack()
			{
				Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "MeleeAttack");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr);
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "RangeMultiplier");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "DamageMultiplier");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AnimationTrigger");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "DamageDelay");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AttackSoundDelay");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AttackClips");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "HitClips");
				AvatarMeleeWeapon.MeleeAttack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, 100680177);
			}

			// Token: 0x0600D5C3 RID: 54723 RVA: 0x0032ED9C File Offset: 0x0032CF9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251287, XrefRangeEnd = 251291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeleeAttack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.MeleeAttack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5C4 RID: 54724 RVA: 0x00068023 File Offset: 0x00066223
			public MeleeAttack(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700423D RID: 16957
			// (get) Token: 0x0600D5C5 RID: 54725 RVA: 0x0032EDD8 File Offset: 0x0032CFD8
			// (set) Token: 0x0600D5C6 RID: 54726 RVA: 0x0006802C File Offset: 0x0006622C
			public unsafe float RangeMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier)) = value;
				}
			}

			// Token: 0x1700423E RID: 16958
			// (get) Token: 0x0600D5C7 RID: 54727 RVA: 0x0032EE00 File Offset: 0x0032D000
			// (set) Token: 0x0600D5C8 RID: 54728 RVA: 0x00068047 File Offset: 0x00066247
			public unsafe float DamageMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier)) = value;
				}
			}

			// Token: 0x1700423F RID: 16959
			// (get) Token: 0x0600D5C9 RID: 54729 RVA: 0x0032EE28 File Offset: 0x0032D028
			// (set) Token: 0x0600D5CA RID: 54730 RVA: 0x00068062 File Offset: 0x00066262
			public unsafe string AnimationTrigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004240 RID: 16960
			// (get) Token: 0x0600D5CB RID: 54731 RVA: 0x0032EE50 File Offset: 0x0032D050
			// (set) Token: 0x0600D5CC RID: 54732 RVA: 0x00068081 File Offset: 0x00066281
			public unsafe float DamageDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay)) = value;
				}
			}

			// Token: 0x17004241 RID: 16961
			// (get) Token: 0x0600D5CD RID: 54733 RVA: 0x0032EE78 File Offset: 0x0032D078
			// (set) Token: 0x0600D5CE RID: 54734 RVA: 0x0006809C File Offset: 0x0006629C
			public unsafe float AttackSoundDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay)) = value;
				}
			}

			// Token: 0x17004242 RID: 16962
			// (get) Token: 0x0600D5CF RID: 54735 RVA: 0x0032EEA0 File Offset: 0x0032D0A0
			// (set) Token: 0x0600D5D0 RID: 54736 RVA: 0x000680B7 File Offset: 0x000662B7
			public unsafe Il2CppReferenceArray<AudioClip> AttackClips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004243 RID: 16963
			// (get) Token: 0x0600D5D1 RID: 54737 RVA: 0x0032EED0 File Offset: 0x0032D0D0
			// (set) Token: 0x0600D5D2 RID: 54738 RVA: 0x000680D6 File Offset: 0x000662D6
			public unsafe Il2CppReferenceArray<AudioClip> HitClips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FCD RID: 36813
			private static readonly IntPtr NativeFieldInfoPtr_RangeMultiplier;

			// Token: 0x04008FCE RID: 36814
			private static readonly IntPtr NativeFieldInfoPtr_DamageMultiplier;

			// Token: 0x04008FCF RID: 36815
			private static readonly IntPtr NativeFieldInfoPtr_AnimationTrigger;

			// Token: 0x04008FD0 RID: 36816
			private static readonly IntPtr NativeFieldInfoPtr_DamageDelay;

			// Token: 0x04008FD1 RID: 36817
			private static readonly IntPtr NativeFieldInfoPtr_AttackSoundDelay;

			// Token: 0x04008FD2 RID: 36818
			private static readonly IntPtr NativeFieldInfoPtr_AttackClips;

			// Token: 0x04008FD3 RID: 36819
			private static readonly IntPtr NativeFieldInfoPtr_HitClips;

			// Token: 0x04008FD4 RID: 36820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AF7 RID: 2807
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5D3 RID: 54739 RVA: 0x0032EF00 File Offset: 0x0032D100
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr);
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "attack");
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "npc");
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, 100680178);
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, 100680179);
			}

			// Token: 0x0600D5D4 RID: 54740 RVA: 0x0032EF90 File Offset: 0x0032D190
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5D5 RID: 54741 RVA: 0x0032EFCC File Offset: 0x0032D1CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251322, XrefRangeEnd = 251327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D5D6 RID: 54742 RVA: 0x000680F5 File Offset: 0x000662F5
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004244 RID: 16964
			// (get) Token: 0x0600D5D7 RID: 54743 RVA: 0x0032F00C File Offset: 0x0032D20C
			// (set) Token: 0x0600D5D8 RID: 54744 RVA: 0x000680FE File Offset: 0x000662FE
			public unsafe AvatarMeleeWeapon.MeleeAttack attack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_attack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon.MeleeAttack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_attack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004245 RID: 16965
			// (get) Token: 0x0600D5D9 RID: 54745 RVA: 0x0032F03C File Offset: 0x0032D23C
			// (set) Token: 0x0600D5DA RID: 54746 RVA: 0x0006811D File Offset: 0x0006631D
			public unsafe AvatarMeleeWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004246 RID: 16966
			// (get) Token: 0x0600D5DB RID: 54747 RVA: 0x0032F06C File Offset: 0x0032D26C
			// (set) Token: 0x0600D5DC RID: 54748 RVA: 0x0006813C File Offset: 0x0006633C
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FD5 RID: 36821
			private static readonly IntPtr NativeFieldInfoPtr_attack;

			// Token: 0x04008FD6 RID: 36822
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FD7 RID: 36823
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x04008FD8 RID: 36824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FD9 RID: 36825
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C68 RID: 3176
			[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon+<>c__DisplayClass10_0+<<Attack>g__AttackRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E491 RID: 58513 RVA: 0x00359674 File Offset: 0x00357874
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "<<Attack>g__AttackRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680180);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680181);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680182);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680183);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680184);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680185);
				}

				// Token: 0x0600E492 RID: 58514 RVA: 0x00359754 File Offset: 0x00357954
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E493 RID: 58515 RVA: 0x0035979C File Offset: 0x0035799C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E494 RID: 58516 RVA: 0x003597D0 File Offset: 0x003579D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251291, XrefRangeEnd = 251317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004703 RID: 18179
				// (get) Token: 0x0600E495 RID: 58517 RVA: 0x0035980C File Offset: 0x00357A0C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E496 RID: 58518 RVA: 0x0035984C File Offset: 0x00357A4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251317, XrefRangeEnd = 251322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004704 RID: 18180
				// (get) Token: 0x0600E497 RID: 58519 RVA: 0x00359880 File Offset: 0x00357A80
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E498 RID: 58520 RVA: 0x0006F717 File Offset: 0x0006D917
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004700 RID: 18176
				// (get) Token: 0x0600E499 RID: 58521 RVA: 0x003598C0 File Offset: 0x00357AC0
				// (set) Token: 0x0600E49A RID: 58522 RVA: 0x0006F720 File Offset: 0x0006D920
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004701 RID: 18177
				// (get) Token: 0x0600E49B RID: 58523 RVA: 0x003598E8 File Offset: 0x00357AE8
				// (set) Token: 0x0600E49C RID: 58524 RVA: 0x0006F73B File Offset: 0x0006D93B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004702 RID: 18178
				// (get) Token: 0x0600E49D RID: 58525 RVA: 0x00359918 File Offset: 0x00357B18
				// (set) Token: 0x0600E49E RID: 58526 RVA: 0x0006F75A File Offset: 0x0006D95A
				public unsafe AvatarMeleeWeapon.__c__DisplayClass10_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon.__c__DisplayClass10_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098E2 RID: 39138
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098E3 RID: 39139
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098E4 RID: 39140
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098E5 RID: 39141
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098E6 RID: 39142
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098E7 RID: 39143
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098E8 RID: 39144
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098E9 RID: 39145
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098EA RID: 39146
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
