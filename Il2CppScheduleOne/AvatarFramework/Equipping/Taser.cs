using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000603 RID: 1539
	public class Taser : AvatarRangedWeapon
	{
		// Token: 0x060087AB RID: 34731 RVA: 0x0023C76C File Offset: 0x0023A96C
		// Note: this type is marked as 'beforefieldinit'.
		static Taser()
		{
			Il2CppClassPointerStore<Taser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "Taser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Taser>.NativeClassPtr);
			Taser.NativeFieldInfoPtr_TaseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "TaseDuration");
			Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "TaseMoveSpeedMultiplier");
			Taser.NativeFieldInfoPtr_FlashObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "FlashObject");
			Taser.NativeFieldInfoPtr_ChargeSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "ChargeSound");
			Taser.NativeFieldInfoPtr_RayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "RayPrefab");
			Taser.NativeFieldInfoPtr_flashRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "flashRoutine");
			Taser.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680219);
			Taser.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680220);
			Taser.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680221);
			Taser.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680222);
			Taser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680223);
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x0023C878 File Offset: 0x0023AA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251609, XrefRangeEnd = 251620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x0023C8C8 File Offset: 0x0023AAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251620, XrefRangeEnd = 251631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x0023C914 File Offset: 0x0023AB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251631, XrefRangeEnd = 251637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIsRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref raised;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x0023C960 File Offset: 0x0023AB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251637, XrefRangeEnd = 251642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flash(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x0023C9AC File Offset: 0x0023ABAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251642, XrefRangeEnd = 251646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Taser() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Taser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x00040A30 File Offset: 0x0003EC30
		public Taser(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x060087B2 RID: 34738 RVA: 0x0023C9E8 File Offset: 0x0023ABE8
		// (set) Token: 0x060087B3 RID: 34739 RVA: 0x00040A39 File Offset: 0x0003EC39
		public unsafe static float TaseDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Taser.NativeFieldInfoPtr_TaseDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Taser.NativeFieldInfoPtr_TaseDuration, (void*)(&value));
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x060087B4 RID: 34740 RVA: 0x0023CA04 File Offset: 0x0023AC04
		// (set) Token: 0x060087B5 RID: 34741 RVA: 0x00040A47 File Offset: 0x0003EC47
		public unsafe static float TaseMoveSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x060087B6 RID: 34742 RVA: 0x0023CA20 File Offset: 0x0023AC20
		// (set) Token: 0x060087B7 RID: 34743 RVA: 0x00040A55 File Offset: 0x0003EC55
		public unsafe GameObject FlashObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_FlashObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_FlashObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x060087B8 RID: 34744 RVA: 0x0023CA50 File Offset: 0x0023AC50
		// (set) Token: 0x060087B9 RID: 34745 RVA: 0x00040A74 File Offset: 0x0003EC74
		public unsafe AudioSourceController ChargeSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_ChargeSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_ChargeSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x060087BA RID: 34746 RVA: 0x0023CA80 File Offset: 0x0023AC80
		// (set) Token: 0x060087BB RID: 34747 RVA: 0x00040A93 File Offset: 0x0003EC93
		public unsafe GameObject RayPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_RayPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_RayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x060087BC RID: 34748 RVA: 0x0023CAB0 File Offset: 0x0023ACB0
		// (set) Token: 0x060087BD RID: 34749 RVA: 0x00040AB2 File Offset: 0x0003ECB2
		public unsafe Coroutine flashRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_flashRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_flashRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C40 RID: 23616
		private static readonly IntPtr NativeFieldInfoPtr_TaseDuration;

		// Token: 0x04005C41 RID: 23617
		private static readonly IntPtr NativeFieldInfoPtr_TaseMoveSpeedMultiplier;

		// Token: 0x04005C42 RID: 23618
		private static readonly IntPtr NativeFieldInfoPtr_FlashObject;

		// Token: 0x04005C43 RID: 23619
		private static readonly IntPtr NativeFieldInfoPtr_ChargeSound;

		// Token: 0x04005C44 RID: 23620
		private static readonly IntPtr NativeFieldInfoPtr_RayPrefab;

		// Token: 0x04005C45 RID: 23621
		private static readonly IntPtr NativeFieldInfoPtr_flashRoutine;

		// Token: 0x04005C46 RID: 23622
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04005C47 RID: 23623
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0;

		// Token: 0x04005C48 RID: 23624
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0;

		// Token: 0x04005C49 RID: 23625
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0;

		// Token: 0x04005C4A RID: 23626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AFA RID: 2810
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.Taser+<Flash>d__9")]
		public sealed class _Flash_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600D5FB RID: 54779 RVA: 0x0032F680 File Offset: 0x0032D880
			// Note: this type is marked as 'beforefieldinit'.
			static _Flash_d__9()
			{
				Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Taser>.NativeClassPtr, "<Flash>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr);
				Taser._Flash_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "<>1__state");
				Taser._Flash_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "<>2__current");
				Taser._Flash_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "<>4__this");
				Taser._Flash_d__9.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "endPoint");
				Taser._Flash_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680224);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680225);
				Taser._Flash_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680226);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680227);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680228);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680229);
			}

			// Token: 0x0600D5FC RID: 54780 RVA: 0x0032F774 File Offset: 0x0032D974
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Flash_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5FD RID: 54781 RVA: 0x0032F7BC File Offset: 0x0032D9BC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5FE RID: 54782 RVA: 0x0032F7F0 File Offset: 0x0032D9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251568, XrefRangeEnd = 251604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004256 RID: 16982
			// (get) Token: 0x0600D5FF RID: 54783 RVA: 0x0032F82C File Offset: 0x0032DA2C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D600 RID: 54784 RVA: 0x0032F86C File Offset: 0x0032DA6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251604, XrefRangeEnd = 251609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004257 RID: 16983
			// (get) Token: 0x0600D601 RID: 54785 RVA: 0x0032F8A0 File Offset: 0x0032DAA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D602 RID: 54786 RVA: 0x0006823A File Offset: 0x0006643A
			public _Flash_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004252 RID: 16978
			// (get) Token: 0x0600D603 RID: 54787 RVA: 0x0032F8E0 File Offset: 0x0032DAE0
			// (set) Token: 0x0600D604 RID: 54788 RVA: 0x00068243 File Offset: 0x00066443
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004253 RID: 16979
			// (get) Token: 0x0600D605 RID: 54789 RVA: 0x0032F908 File Offset: 0x0032DB08
			// (set) Token: 0x0600D606 RID: 54790 RVA: 0x0006825E File Offset: 0x0006645E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004254 RID: 16980
			// (get) Token: 0x0600D607 RID: 54791 RVA: 0x0032F938 File Offset: 0x0032DB38
			// (set) Token: 0x0600D608 RID: 54792 RVA: 0x0006827D File Offset: 0x0006647D
			public unsafe Taser __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Taser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004255 RID: 16981
			// (get) Token: 0x0600D609 RID: 54793 RVA: 0x0032F968 File Offset: 0x0032DB68
			// (set) Token: 0x0600D60A RID: 54794 RVA: 0x0006829C File Offset: 0x0006649C
			public unsafe Vector3 endPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr_endPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr_endPoint)) = value;
				}
			}

			// Token: 0x04008FED RID: 36845
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FEE RID: 36846
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FEF RID: 36847
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FF0 RID: 36848
			private static readonly IntPtr NativeFieldInfoPtr_endPoint;

			// Token: 0x04008FF1 RID: 36849
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FF2 RID: 36850
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FF3 RID: 36851
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FF4 RID: 36852
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FF5 RID: 36853
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FF6 RID: 36854
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
