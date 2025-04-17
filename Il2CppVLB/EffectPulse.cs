using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppVLB
{
	// Token: 0x02000083 RID: 131
	public class EffectPulse : EffectAbstractBase
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x0008DB54 File Offset: 0x0008BD54
		// Note: this type is marked as 'beforefieldinit'.
		static EffectPulse()
		{
			Il2CppClassPointerStore<EffectPulse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectPulse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr);
			EffectPulse.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "ClassName");
			EffectPulse.NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "frequency");
			EffectPulse.NativeFieldInfoPtr_intensityAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "intensityAmplitude");
			EffectPulse.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100664325);
			EffectPulse.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100664326);
			EffectPulse.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100664327);
			EffectPulse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100664328);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0008DC10 File Offset: 0x0008BE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80272, XrefRangeEnd = 80284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitFrom(EffectAbstractBase source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectPulse.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0008DC60 File Offset: 0x0008BE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80284, XrefRangeEnd = 80291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectPulse.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0008DC9C File Offset: 0x0008BE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80291, XrefRangeEnd = 80296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0008DCDC File Offset: 0x0008BEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80296, XrefRangeEnd = 80308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectPulse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00007289 File Offset: 0x00005489
		public EffectPulse(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0008DD18 File Offset: 0x0008BF18
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00007292 File Offset: 0x00005492
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectPulse.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectPulse.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0008DD38 File Offset: 0x0008BF38
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x000072A4 File Offset: 0x000054A4
		public unsafe float frequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_frequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_frequency)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0008DD60 File Offset: 0x0008BF60
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x000072BF File Offset: 0x000054BF
		public unsafe MinMaxRangeFloat intensityAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_intensityAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_intensityAmplitude)) = value;
			}
		}

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_frequency;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_intensityAmplitude;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200081A RID: 2074
		[ObfuscatedName("VLB.EffectPulse+<CoUpdate>d__5")]
		public sealed class _CoUpdate_d__5 : Object
		{
			// Token: 0x0600BE4F RID: 48719 RVA: 0x002EB534 File Offset: 0x002E9734
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdate_d__5()
			{
				Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "<CoUpdate>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr);
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<>1__state");
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<>2__current");
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<>4__this");
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<t>5__2");
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664329);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664330);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664331);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664332);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664333);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664334);
			}

			// Token: 0x0600BE50 RID: 48720 RVA: 0x002EB628 File Offset: 0x002E9828
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdate_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE51 RID: 48721 RVA: 0x002EB670 File Offset: 0x002E9870
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE52 RID: 48722 RVA: 0x002EB6A4 File Offset: 0x002E98A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80236, XrefRangeEnd = 80242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B33 RID: 15155
			// (get) Token: 0x0600BE53 RID: 48723 RVA: 0x002EB6E0 File Offset: 0x002E98E0
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE54 RID: 48724 RVA: 0x002EB720 File Offset: 0x002E9920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80242, XrefRangeEnd = 80272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B34 RID: 15156
			// (get) Token: 0x0600BE55 RID: 48725 RVA: 0x002EB754 File Offset: 0x002E9954
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE56 RID: 48726 RVA: 0x0005D1AF File Offset: 0x0005B3AF
			public _CoUpdate_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B2F RID: 15151
			// (get) Token: 0x0600BE57 RID: 48727 RVA: 0x002EB794 File Offset: 0x002E9994
			// (set) Token: 0x0600BE58 RID: 48728 RVA: 0x0005D1B8 File Offset: 0x0005B3B8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B30 RID: 15152
			// (get) Token: 0x0600BE59 RID: 48729 RVA: 0x002EB7BC File Offset: 0x002E99BC
			// (set) Token: 0x0600BE5A RID: 48730 RVA: 0x0005D1D3 File Offset: 0x0005B3D3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B31 RID: 15153
			// (get) Token: 0x0600BE5B RID: 48731 RVA: 0x002EB7EC File Offset: 0x002E99EC
			// (set) Token: 0x0600BE5C RID: 48732 RVA: 0x0005D1F2 File Offset: 0x0005B3F2
			public unsafe EffectPulse __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectPulse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B32 RID: 15154
			// (get) Token: 0x0600BE5D RID: 48733 RVA: 0x002EB81C File Offset: 0x002E9A1C
			// (set) Token: 0x0600BE5E RID: 48734 RVA: 0x0005D211 File Offset: 0x0005B411
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x040080BE RID: 32958
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040080BF RID: 32959
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040080C0 RID: 32960
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040080C1 RID: 32961
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x040080C2 RID: 32962
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040080C3 RID: 32963
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080C4 RID: 32964
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040080C5 RID: 32965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040080C6 RID: 32966
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080C7 RID: 32967
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
