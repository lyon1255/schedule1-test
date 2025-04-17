using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B3 RID: 947
	public class BlinkingLight : MonoBehaviour
	{
		// Token: 0x060049CC RID: 18892 RVA: 0x001672B0 File Offset: 0x001654B0
		// Note: this type is marked as 'beforefieldinit'.
		static BlinkingLight()
		{
			Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "BlinkingLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr);
			BlinkingLight.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "IsOn");
			BlinkingLight.NativeFieldInfoPtr_OnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "OnTime");
			BlinkingLight.NativeFieldInfoPtr_OffTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "OffTime");
			BlinkingLight.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "light");
			BlinkingLight.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "blinkRoutine");
			BlinkingLight.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672458);
			BlinkingLight.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672459);
			BlinkingLight.NativeMethodInfoPtr_Blink_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672460);
			BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672461);
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x00167394 File Offset: 0x00165594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163565, XrefRangeEnd = 163569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x001673C8 File Offset: 0x001655C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163569, XrefRangeEnd = 163576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x001673FC File Offset: 0x001655FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163576, XrefRangeEnd = 163581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Blink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Blink_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x0016743C File Offset: 0x0016563C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163581, XrefRangeEnd = 163582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlinkingLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x00023886 File Offset: 0x00021A86
		public BlinkingLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x060049D2 RID: 18898 RVA: 0x00167478 File Offset: 0x00165678
		// (set) Token: 0x060049D3 RID: 18899 RVA: 0x0002388F File Offset: 0x00021A8F
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x060049D4 RID: 18900 RVA: 0x001674A0 File Offset: 0x001656A0
		// (set) Token: 0x060049D5 RID: 18901 RVA: 0x000238AA File Offset: 0x00021AAA
		public unsafe float OnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OnTime)) = value;
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x060049D6 RID: 18902 RVA: 0x001674C8 File Offset: 0x001656C8
		// (set) Token: 0x060049D7 RID: 18903 RVA: 0x000238C5 File Offset: 0x00021AC5
		public unsafe float OffTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OffTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OffTime)) = value;
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x060049D8 RID: 18904 RVA: 0x001674F0 File Offset: 0x001656F0
		// (set) Token: 0x060049D9 RID: 18905 RVA: 0x000238E0 File Offset: 0x00021AE0
		public unsafe ToggleableLight light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x060049DA RID: 18906 RVA: 0x00167520 File Offset: 0x00165720
		// (set) Token: 0x060049DB RID: 18907 RVA: 0x000238FF File Offset: 0x00021AFF
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031C5 RID: 12741
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x040031C6 RID: 12742
		private static readonly IntPtr NativeFieldInfoPtr_OnTime;

		// Token: 0x040031C7 RID: 12743
		private static readonly IntPtr NativeFieldInfoPtr_OffTime;

		// Token: 0x040031C8 RID: 12744
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x040031C9 RID: 12745
		private static readonly IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x040031CA RID: 12746
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040031CB RID: 12747
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040031CC RID: 12748
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Private_IEnumerator_0;

		// Token: 0x040031CD RID: 12749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000984 RID: 2436
		[ObfuscatedName("ScheduleOne.Lighting.BlinkingLight+<Blink>d__7")]
		public sealed class _Blink_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600CA14 RID: 51732 RVA: 0x0030E178 File Offset: 0x0030C378
			// Note: this type is marked as 'beforefieldinit'.
			static _Blink_d__7()
			{
				Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "<Blink>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr);
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>1__state");
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>2__current");
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>4__this");
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672462);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672463);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672464);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672465);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672466);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672467);
			}

			// Token: 0x0600CA15 RID: 51733 RVA: 0x0030E258 File Offset: 0x0030C458
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Blink_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA16 RID: 51734 RVA: 0x0030E2A0 File Offset: 0x0030C4A0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA17 RID: 51735 RVA: 0x0030E2D4 File Offset: 0x0030C4D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163559, XrefRangeEnd = 163560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EFA RID: 16122
			// (get) Token: 0x0600CA18 RID: 51736 RVA: 0x0030E310 File Offset: 0x0030C510
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA19 RID: 51737 RVA: 0x0030E350 File Offset: 0x0030C550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163560, XrefRangeEnd = 163565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EFB RID: 16123
			// (get) Token: 0x0600CA1A RID: 51738 RVA: 0x0030E384 File Offset: 0x0030C584
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA1B RID: 51739 RVA: 0x00062414 File Offset: 0x00060614
			public _Blink_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF7 RID: 16119
			// (get) Token: 0x0600CA1C RID: 51740 RVA: 0x0030E3C4 File Offset: 0x0030C5C4
			// (set) Token: 0x0600CA1D RID: 51741 RVA: 0x0006241D File Offset: 0x0006061D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EF8 RID: 16120
			// (get) Token: 0x0600CA1E RID: 51742 RVA: 0x0030E3EC File Offset: 0x0030C5EC
			// (set) Token: 0x0600CA1F RID: 51743 RVA: 0x00062438 File Offset: 0x00060638
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF9 RID: 16121
			// (get) Token: 0x0600CA20 RID: 51744 RVA: 0x0030E41C File Offset: 0x0030C61C
			// (set) Token: 0x0600CA21 RID: 51745 RVA: 0x00062457 File Offset: 0x00060657
			public unsafe BlinkingLight __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlinkingLight>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088B3 RID: 34995
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088B4 RID: 34996
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088B5 RID: 34997
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088B6 RID: 34998
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088B7 RID: 34999
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088B8 RID: 35000
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088B9 RID: 35001
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088BA RID: 35002
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088BB RID: 35003
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
