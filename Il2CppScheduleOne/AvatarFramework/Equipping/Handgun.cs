using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000602 RID: 1538
	public class Handgun : AvatarRangedWeapon
	{
		// Token: 0x0600879A RID: 34714 RVA: 0x0023C494 File Offset: 0x0023A694
		// Note: this type is marked as 'beforefieldinit'.
		static Handgun()
		{
			Il2CppClassPointerStore<Handgun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "Handgun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Handgun>.NativeClassPtr);
			Handgun.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "Anim");
			Handgun.NativeFieldInfoPtr_ShellParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "ShellParticles");
			Handgun.NativeFieldInfoPtr_SmokeParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "SmokeParticles");
			Handgun.NativeFieldInfoPtr_FlashObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "FlashObject");
			Handgun.NativeFieldInfoPtr_RayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "RayPrefab");
			Handgun.NativeFieldInfoPtr_flashRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "flashRoutine");
			Handgun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun>.NativeClassPtr, 100680210);
			Handgun.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun>.NativeClassPtr, 100680211);
			Handgun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun>.NativeClassPtr, 100680212);
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x0023C578 File Offset: 0x0023A778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251539, XrefRangeEnd = 251559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Handgun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x0023C5C4 File Offset: 0x0023A7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251559, XrefRangeEnd = 251564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flash(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x0023C610 File Offset: 0x0023A810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251564, XrefRangeEnd = 251568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Handgun() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Handgun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x0004096D File Offset: 0x0003EB6D
		public Handgun(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x0600879F RID: 34719 RVA: 0x0023C64C File Offset: 0x0023A84C
		// (set) Token: 0x060087A0 RID: 34720 RVA: 0x00040976 File Offset: 0x0003EB76
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x060087A1 RID: 34721 RVA: 0x0023C67C File Offset: 0x0023A87C
		// (set) Token: 0x060087A2 RID: 34722 RVA: 0x00040995 File Offset: 0x0003EB95
		public unsafe ParticleSystem ShellParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_ShellParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_ShellParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x060087A3 RID: 34723 RVA: 0x0023C6AC File Offset: 0x0023A8AC
		// (set) Token: 0x060087A4 RID: 34724 RVA: 0x000409B4 File Offset: 0x0003EBB4
		public unsafe ParticleSystem SmokeParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_SmokeParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_SmokeParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x060087A5 RID: 34725 RVA: 0x0023C6DC File Offset: 0x0023A8DC
		// (set) Token: 0x060087A6 RID: 34726 RVA: 0x000409D3 File Offset: 0x0003EBD3
		public unsafe Transform FlashObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_FlashObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_FlashObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x060087A7 RID: 34727 RVA: 0x0023C70C File Offset: 0x0023A90C
		// (set) Token: 0x060087A8 RID: 34728 RVA: 0x000409F2 File Offset: 0x0003EBF2
		public unsafe GameObject RayPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_RayPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_RayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x060087A9 RID: 34729 RVA: 0x0023C73C File Offset: 0x0023A93C
		// (set) Token: 0x060087AA RID: 34730 RVA: 0x00040A11 File Offset: 0x0003EC11
		public unsafe Coroutine flashRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_flashRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_flashRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C37 RID: 23607
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005C38 RID: 23608
		private static readonly IntPtr NativeFieldInfoPtr_ShellParticles;

		// Token: 0x04005C39 RID: 23609
		private static readonly IntPtr NativeFieldInfoPtr_SmokeParticles;

		// Token: 0x04005C3A RID: 23610
		private static readonly IntPtr NativeFieldInfoPtr_FlashObject;

		// Token: 0x04005C3B RID: 23611
		private static readonly IntPtr NativeFieldInfoPtr_RayPrefab;

		// Token: 0x04005C3C RID: 23612
		private static readonly IntPtr NativeFieldInfoPtr_flashRoutine;

		// Token: 0x04005C3D RID: 23613
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0;

		// Token: 0x04005C3E RID: 23614
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0;

		// Token: 0x04005C3F RID: 23615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF9 RID: 2809
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.Handgun+<Flash>d__7")]
		public sealed class _Flash_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600D5EB RID: 54763 RVA: 0x0032F370 File Offset: 0x0032D570
			// Note: this type is marked as 'beforefieldinit'.
			static _Flash_d__7()
			{
				Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "<Flash>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr);
				Handgun._Flash_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "<>1__state");
				Handgun._Flash_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "<>2__current");
				Handgun._Flash_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "<>4__this");
				Handgun._Flash_d__7.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "endPoint");
				Handgun._Flash_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680213);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680214);
				Handgun._Flash_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680215);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680216);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680217);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680218);
			}

			// Token: 0x0600D5EC RID: 54764 RVA: 0x0032F464 File Offset: 0x0032D664
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Flash_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5ED RID: 54765 RVA: 0x0032F4AC File Offset: 0x0032D6AC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5EE RID: 54766 RVA: 0x0032F4E0 File Offset: 0x0032D6E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251496, XrefRangeEnd = 251534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004250 RID: 16976
			// (get) Token: 0x0600D5EF RID: 54767 RVA: 0x0032F51C File Offset: 0x0032D71C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5F0 RID: 54768 RVA: 0x0032F55C File Offset: 0x0032D75C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251534, XrefRangeEnd = 251539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004251 RID: 16977
			// (get) Token: 0x0600D5F1 RID: 54769 RVA: 0x0032F590 File Offset: 0x0032D790
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5F2 RID: 54770 RVA: 0x000681BD File Offset: 0x000663BD
			public _Flash_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700424C RID: 16972
			// (get) Token: 0x0600D5F3 RID: 54771 RVA: 0x0032F5D0 File Offset: 0x0032D7D0
			// (set) Token: 0x0600D5F4 RID: 54772 RVA: 0x000681C6 File Offset: 0x000663C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700424D RID: 16973
			// (get) Token: 0x0600D5F5 RID: 54773 RVA: 0x0032F5F8 File Offset: 0x0032D7F8
			// (set) Token: 0x0600D5F6 RID: 54774 RVA: 0x000681E1 File Offset: 0x000663E1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700424E RID: 16974
			// (get) Token: 0x0600D5F7 RID: 54775 RVA: 0x0032F628 File Offset: 0x0032D828
			// (set) Token: 0x0600D5F8 RID: 54776 RVA: 0x00068200 File Offset: 0x00066400
			public unsafe Handgun __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Handgun>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700424F RID: 16975
			// (get) Token: 0x0600D5F9 RID: 54777 RVA: 0x0032F658 File Offset: 0x0032D858
			// (set) Token: 0x0600D5FA RID: 54778 RVA: 0x0006821F File Offset: 0x0006641F
			public unsafe Vector3 endPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr_endPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr_endPoint)) = value;
				}
			}

			// Token: 0x04008FE3 RID: 36835
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FE4 RID: 36836
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FE5 RID: 36837
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FE6 RID: 36838
			private static readonly IntPtr NativeFieldInfoPtr_endPoint;

			// Token: 0x04008FE7 RID: 36839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FE8 RID: 36840
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FE9 RID: 36841
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FEA RID: 36842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FEB RID: 36843
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FEC RID: 36844
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
