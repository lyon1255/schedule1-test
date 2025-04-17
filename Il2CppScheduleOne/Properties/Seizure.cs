using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001E7 RID: 487
	public class Seizure : Property
	{
		// Token: 0x060027FC RID: 10236 RVA: 0x000EEA2C File Offset: 0x000ECC2C
		// Note: this type is marked as 'beforefieldinit'.
		static Seizure()
		{
			Il2CppClassPointerStore<Seizure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Seizure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Seizure>.NativeClassPtr);
			Seizure.NativeFieldInfoPtr_CAMERA_JITTER_INTENSITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure>.NativeClassPtr, "CAMERA_JITTER_INTENSITY");
			Seizure.NativeFieldInfoPtr_DURATION_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure>.NativeClassPtr, "DURATION_NPC");
			Seizure.NativeFieldInfoPtr_DURATION_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure>.NativeClassPtr, "DURATION_PLAYER");
			Seizure.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure>.NativeClassPtr, 100667791);
			Seizure.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure>.NativeClassPtr, 100667792);
			Seizure.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure>.NativeClassPtr, 100667793);
			Seizure.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure>.NativeClassPtr, 100667794);
			Seizure.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure>.NativeClassPtr, 100667795);
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000EEAFC File Offset: 0x000ECCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118211, XrefRangeEnd = 118229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seizure.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000EEB4C File Offset: 0x000ECD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118229, XrefRangeEnd = 118245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seizure.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000EEB9C File Offset: 0x000ECD9C
		[CallerCount(0)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seizure.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000EEBEC File Offset: 0x000ECDEC
		[CallerCount(0)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Seizure.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000EEC3C File Offset: 0x000ECE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Seizure() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Seizure>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00015D7E File Offset: 0x00013F7E
		public Seizure(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x000EEC78 File Offset: 0x000ECE78
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x00015D87 File Offset: 0x00013F87
		public unsafe static float CAMERA_JITTER_INTENSITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Seizure.NativeFieldInfoPtr_CAMERA_JITTER_INTENSITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Seizure.NativeFieldInfoPtr_CAMERA_JITTER_INTENSITY, (void*)(&value));
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x000EEC94 File Offset: 0x000ECE94
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x00015D95 File Offset: 0x00013F95
		public unsafe static float DURATION_NPC
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Seizure.NativeFieldInfoPtr_DURATION_NPC, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Seizure.NativeFieldInfoPtr_DURATION_NPC, (void*)(&value));
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x000EECB0 File Offset: 0x000ECEB0
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x00015DA3 File Offset: 0x00013FA3
		public unsafe static float DURATION_PLAYER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Seizure.NativeFieldInfoPtr_DURATION_PLAYER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Seizure.NativeFieldInfoPtr_DURATION_PLAYER, (void*)(&value));
			}
		}

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeFieldInfoPtr_CAMERA_JITTER_INTENSITY;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeFieldInfoPtr_DURATION_NPC;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeFieldInfoPtr_DURATION_PLAYER;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008D5 RID: 2261
		[ObfuscatedName("ScheduleOne.Properties.Seizure+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C435 RID: 50229 RVA: 0x002FCDE0 File Offset: 0x002FAFE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Seizure>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0>.NativeClassPtr);
				Seizure.__c__DisplayClass3_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0>.NativeClassPtr, "npc");
				Seizure.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0>.NativeClassPtr, 100667796);
				Seizure.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0>.NativeClassPtr, 100667797);
			}

			// Token: 0x0600C436 RID: 50230 RVA: 0x002FCE48 File Offset: 0x002FB048
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C437 RID: 50231 RVA: 0x002FCE84 File Offset: 0x002FB084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118191, XrefRangeEnd = 118196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C438 RID: 50232 RVA: 0x0005F7C9 File Offset: 0x0005D9C9
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D3E RID: 15678
			// (get) Token: 0x0600C439 RID: 50233 RVA: 0x002FCEC4 File Offset: 0x002FB0C4
			// (set) Token: 0x0600C43A RID: 50234 RVA: 0x0005F7D2 File Offset: 0x0005D9D2
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass3_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass3_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084F9 RID: 34041
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x040084FA RID: 34042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084FB RID: 34043
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C33 RID: 3123
			[ObfuscatedName("ScheduleOne.Properties.Seizure+<>c__DisplayClass3_0+<<ApplyToNPC>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
			{
				// Token: 0x0600E159 RID: 57689 RVA: 0x0034F7C0 File Offset: 0x0034D9C0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0>.NativeClassPtr, "<<ApplyToNPC>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667798);
					Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667799);
					Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667800);
					Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667801);
					Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667802);
					Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667803);
				}

				// Token: 0x0600E15A RID: 57690 RVA: 0x0034F8A0 File Offset: 0x0034DAA0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E15B RID: 57691 RVA: 0x0034F8E8 File Offset: 0x0034DAE8
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E15C RID: 57692 RVA: 0x0034F91C File Offset: 0x0034DB1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118181, XrefRangeEnd = 118186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045D4 RID: 17876
				// (get) Token: 0x0600E15D RID: 57693 RVA: 0x0034F958 File Offset: 0x0034DB58
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E15E RID: 57694 RVA: 0x0034F998 File Offset: 0x0034DB98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118186, XrefRangeEnd = 118191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045D5 RID: 17877
				// (get) Token: 0x0600E15F RID: 57695 RVA: 0x0034F9CC File Offset: 0x0034DBCC
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E160 RID: 57696 RVA: 0x0006DDDE File Offset: 0x0006BFDE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045D1 RID: 17873
				// (get) Token: 0x0600E161 RID: 57697 RVA: 0x0034FA0C File Offset: 0x0034DC0C
				// (set) Token: 0x0600E162 RID: 57698 RVA: 0x0006DDE7 File Offset: 0x0006BFE7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045D2 RID: 17874
				// (get) Token: 0x0600E163 RID: 57699 RVA: 0x0034FA34 File Offset: 0x0034DC34
				// (set) Token: 0x0600E164 RID: 57700 RVA: 0x0006DE02 File Offset: 0x0006C002
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045D3 RID: 17875
				// (get) Token: 0x0600E165 RID: 57701 RVA: 0x0034FA64 File Offset: 0x0034DC64
				// (set) Token: 0x0600E166 RID: 57702 RVA: 0x0006DE21 File Offset: 0x0006C021
				public unsafe Seizure.__c__DisplayClass3_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seizure.__c__DisplayClass3_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040096E2 RID: 38626
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096E3 RID: 38627
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096E4 RID: 38628
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096E5 RID: 38629
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096E6 RID: 38630
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096E7 RID: 38631
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096E8 RID: 38632
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096E9 RID: 38633
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096EA RID: 38634
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008D6 RID: 2262
		[ObfuscatedName("ScheduleOne.Properties.Seizure+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600C43B RID: 50235 RVA: 0x002FCEF4 File Offset: 0x002FB0F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Seizure>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0>.NativeClassPtr);
				Seizure.__c__DisplayClass4_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0>.NativeClassPtr, "player");
				Seizure.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0>.NativeClassPtr, 100667804);
				Seizure.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0>.NativeClassPtr, 100667805);
			}

			// Token: 0x0600C43C RID: 50236 RVA: 0x002FCF5C File Offset: 0x002FB15C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C43D RID: 50237 RVA: 0x002FCF98 File Offset: 0x002FB198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118206, XrefRangeEnd = 118211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C43E RID: 50238 RVA: 0x0005F7F1 File Offset: 0x0005D9F1
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D3F RID: 15679
			// (get) Token: 0x0600C43F RID: 50239 RVA: 0x002FCFD8 File Offset: 0x002FB1D8
			// (set) Token: 0x0600C440 RID: 50240 RVA: 0x0005F7FA File Offset: 0x0005D9FA
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass4_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass4_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084FC RID: 34044
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040084FD RID: 34045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084FE RID: 34046
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C34 RID: 3124
			[ObfuscatedName("ScheduleOne.Properties.Seizure+<>c__DisplayClass4_0+<<ApplyToPlayer>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
			{
				// Token: 0x0600E167 RID: 57703 RVA: 0x0034FA94 File Offset: 0x0034DC94
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0>.NativeClassPtr, "<<ApplyToPlayer>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667806);
					Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667807);
					Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667808);
					Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667809);
					Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667810);
					Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667811);
				}

				// Token: 0x0600E168 RID: 57704 RVA: 0x0034FB74 File Offset: 0x0034DD74
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E169 RID: 57705 RVA: 0x0034FBBC File Offset: 0x0034DDBC
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E16A RID: 57706 RVA: 0x0034FBF0 File Offset: 0x0034DDF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118196, XrefRangeEnd = 118201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045D9 RID: 17881
				// (get) Token: 0x0600E16B RID: 57707 RVA: 0x0034FC2C File Offset: 0x0034DE2C
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E16C RID: 57708 RVA: 0x0034FC6C File Offset: 0x0034DE6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118201, XrefRangeEnd = 118206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045DA RID: 17882
				// (get) Token: 0x0600E16D RID: 57709 RVA: 0x0034FCA0 File Offset: 0x0034DEA0
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E16E RID: 57710 RVA: 0x0006DE40 File Offset: 0x0006C040
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045D6 RID: 17878
				// (get) Token: 0x0600E16F RID: 57711 RVA: 0x0034FCE0 File Offset: 0x0034DEE0
				// (set) Token: 0x0600E170 RID: 57712 RVA: 0x0006DE49 File Offset: 0x0006C049
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045D7 RID: 17879
				// (get) Token: 0x0600E171 RID: 57713 RVA: 0x0034FD08 File Offset: 0x0034DF08
				// (set) Token: 0x0600E172 RID: 57714 RVA: 0x0006DE64 File Offset: 0x0006C064
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045D8 RID: 17880
				// (get) Token: 0x0600E173 RID: 57715 RVA: 0x0034FD38 File Offset: 0x0034DF38
				// (set) Token: 0x0600E174 RID: 57716 RVA: 0x0006DE83 File Offset: 0x0006C083
				public unsafe Seizure.__c__DisplayClass4_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seizure.__c__DisplayClass4_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Seizure.__c__DisplayClass4_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040096EB RID: 38635
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096EC RID: 38636
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096ED RID: 38637
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096EE RID: 38638
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096EF RID: 38639
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096F0 RID: 38640
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096F1 RID: 38641
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096F2 RID: 38642
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096F3 RID: 38643
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
