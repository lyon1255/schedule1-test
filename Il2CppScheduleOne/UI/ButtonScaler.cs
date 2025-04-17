using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000627 RID: 1575
	public class ButtonScaler : MonoBehaviour
	{
		// Token: 0x06008AF2 RID: 35570 RVA: 0x00245FB8 File Offset: 0x002441B8
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonScaler()
		{
			Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ButtonScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr);
			ButtonScaler.NativeFieldInfoPtr_ScaleTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "ScaleTarget");
			ButtonScaler.NativeFieldInfoPtr_HoverScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "HoverScale");
			ButtonScaler.NativeFieldInfoPtr_ScaleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "ScaleTime");
			ButtonScaler.NativeFieldInfoPtr_scaleCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "scaleCoroutine");
			ButtonScaler.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "button");
			ButtonScaler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680556);
			ButtonScaler.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680557);
			ButtonScaler.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680558);
			ButtonScaler.NativeMethodInfoPtr_SetScale_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680559);
			ButtonScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680560);
			ButtonScaler.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680561);
			ButtonScaler.NativeMethodInfoPtr__Awake_b__5_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680562);
		}

		// Token: 0x06008AF3 RID: 35571 RVA: 0x002460D8 File Offset: 0x002442D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254612, XrefRangeEnd = 254651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AF4 RID: 35572 RVA: 0x0024610C File Offset: 0x0024430C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254651, XrefRangeEnd = 254652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AF5 RID: 35573 RVA: 0x00246140 File Offset: 0x00244340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254652, XrefRangeEnd = 254653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x00246174 File Offset: 0x00244374
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254667, RefRangeEnd = 254671, XrefRangeStart = 254653, XrefRangeEnd = 254667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr_SetScale_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x002461B4 File Offset: 0x002443B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254671, XrefRangeEnd = 254672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AF8 RID: 35576 RVA: 0x002461F0 File Offset: 0x002443F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AF9 RID: 35577 RVA: 0x00246234 File Offset: 0x00244434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr__Awake_b__5_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x00042829 File Offset: 0x00040A29
		public ButtonScaler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x06008AFB RID: 35579 RVA: 0x00246278 File Offset: 0x00244478
		// (set) Token: 0x06008AFC RID: 35580 RVA: 0x00042832 File Offset: 0x00040A32
		public unsafe RectTransform ScaleTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_ScaleTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_ScaleTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x06008AFD RID: 35581 RVA: 0x002462A8 File Offset: 0x002444A8
		// (set) Token: 0x06008AFE RID: 35582 RVA: 0x00042851 File Offset: 0x00040A51
		public unsafe float HoverScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_HoverScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_HoverScale)) = value;
			}
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x06008AFF RID: 35583 RVA: 0x002462D0 File Offset: 0x002444D0
		// (set) Token: 0x06008B00 RID: 35584 RVA: 0x0004286C File Offset: 0x00040A6C
		public unsafe float ScaleTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_ScaleTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_ScaleTime)) = value;
			}
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x06008B01 RID: 35585 RVA: 0x002462F8 File Offset: 0x002444F8
		// (set) Token: 0x06008B02 RID: 35586 RVA: 0x00042887 File Offset: 0x00040A87
		public unsafe Coroutine scaleCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_scaleCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_scaleCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x06008B03 RID: 35587 RVA: 0x00246328 File Offset: 0x00244528
		// (set) Token: 0x06008B04 RID: 35588 RVA: 0x000428A6 File Offset: 0x00040AA6
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E3B RID: 24123
		private static readonly IntPtr NativeFieldInfoPtr_ScaleTarget;

		// Token: 0x04005E3C RID: 24124
		private static readonly IntPtr NativeFieldInfoPtr_HoverScale;

		// Token: 0x04005E3D RID: 24125
		private static readonly IntPtr NativeFieldInfoPtr_ScaleTime;

		// Token: 0x04005E3E RID: 24126
		private static readonly IntPtr NativeFieldInfoPtr_scaleCoroutine;

		// Token: 0x04005E3F RID: 24127
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04005E40 RID: 24128
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005E41 RID: 24129
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04005E42 RID: 24130
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x04005E43 RID: 24131
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Private_Void_Single_0;

		// Token: 0x04005E44 RID: 24132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005E45 RID: 24133
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_0_Private_Void_BaseEventData_0;

		// Token: 0x04005E46 RID: 24134
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_1_Private_Void_BaseEventData_0;

		// Token: 0x02000B14 RID: 2836
		[ObfuscatedName("ScheduleOne.UI.ButtonScaler+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6BC RID: 54972 RVA: 0x00331984 File Offset: 0x0032FB84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr);
				ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, "endScale");
				ButtonScaler.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, 100680563);
				ButtonScaler.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, 100680564);
			}

			// Token: 0x0600D6BD RID: 54973 RVA: 0x00331A00 File Offset: 0x0032FC00
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6BE RID: 54974 RVA: 0x00331A3C File Offset: 0x0032FC3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254607, XrefRangeEnd = 254612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D6BF RID: 54975 RVA: 0x0006880C File Offset: 0x00066A0C
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004286 RID: 17030
			// (get) Token: 0x0600D6C0 RID: 54976 RVA: 0x00331A7C File Offset: 0x0032FC7C
			// (set) Token: 0x0600D6C1 RID: 54977 RVA: 0x00068815 File Offset: 0x00066A15
			public unsafe ButtonScaler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ButtonScaler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004287 RID: 17031
			// (get) Token: 0x0600D6C2 RID: 54978 RVA: 0x00331AAC File Offset: 0x0032FCAC
			// (set) Token: 0x0600D6C3 RID: 54979 RVA: 0x00068834 File Offset: 0x00066A34
			public unsafe float endScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x0400906A RID: 36970
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400906B RID: 36971
			private static readonly IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x0400906C RID: 36972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400906D RID: 36973
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C6E RID: 3182
			[ObfuscatedName("ScheduleOne.UI.ButtonScaler+<>c__DisplayClass8_0+<<SetScale>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4F9 RID: 58617 RVA: 0x0035A9CC File Offset: 0x00358BCC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, "<<SetScale>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startScale>5__2");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<lerpTime>5__3");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680565);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680566);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680567);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680568);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680569);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680570);
				}

				// Token: 0x0600E4FA RID: 58618 RVA: 0x0035AAE8 File Offset: 0x00358CE8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4FB RID: 58619 RVA: 0x0035AB30 File Offset: 0x00358D30
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4FC RID: 58620 RVA: 0x0035AB64 File Offset: 0x00358D64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254592, XrefRangeEnd = 254602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700472E RID: 18222
				// (get) Token: 0x0600E4FD RID: 58621 RVA: 0x0035ABA0 File Offset: 0x00358DA0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4FE RID: 58622 RVA: 0x0035ABE0 File Offset: 0x00358DE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254602, XrefRangeEnd = 254607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700472F RID: 18223
				// (get) Token: 0x0600E4FF RID: 58623 RVA: 0x0035AC14 File Offset: 0x00358E14
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E500 RID: 58624 RVA: 0x0006FA75 File Offset: 0x0006DC75
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004728 RID: 18216
				// (get) Token: 0x0600E501 RID: 58625 RVA: 0x0035AC54 File Offset: 0x00358E54
				// (set) Token: 0x0600E502 RID: 58626 RVA: 0x0006FA7E File Offset: 0x0006DC7E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004729 RID: 18217
				// (get) Token: 0x0600E503 RID: 58627 RVA: 0x0035AC7C File Offset: 0x00358E7C
				// (set) Token: 0x0600E504 RID: 58628 RVA: 0x0006FA99 File Offset: 0x0006DC99
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700472A RID: 18218
				// (get) Token: 0x0600E505 RID: 58629 RVA: 0x0035ACAC File Offset: 0x00358EAC
				// (set) Token: 0x0600E506 RID: 58630 RVA: 0x0006FAB8 File Offset: 0x0006DCB8
				public unsafe ButtonScaler.__c__DisplayClass8_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ButtonScaler.__c__DisplayClass8_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700472B RID: 18219
				// (get) Token: 0x0600E507 RID: 58631 RVA: 0x0035ACDC File Offset: 0x00358EDC
				// (set) Token: 0x0600E508 RID: 58632 RVA: 0x0006FAD7 File Offset: 0x0006DCD7
				public unsafe float _startScale_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
					}
				}

				// Token: 0x1700472C RID: 18220
				// (get) Token: 0x0600E509 RID: 58633 RVA: 0x0035AD04 File Offset: 0x00358F04
				// (set) Token: 0x0600E50A RID: 58634 RVA: 0x0006FAF2 File Offset: 0x0006DCF2
				public unsafe float _lerpTime_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
					}
				}

				// Token: 0x1700472D RID: 18221
				// (get) Token: 0x0600E50B RID: 58635 RVA: 0x0035AD2C File Offset: 0x00358F2C
				// (set) Token: 0x0600E50C RID: 58636 RVA: 0x0006FB0D File Offset: 0x0006DD0D
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009922 RID: 39202
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009923 RID: 39203
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009924 RID: 39204
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009925 RID: 39205
				private static readonly IntPtr NativeFieldInfoPtr__startScale_5__2;

				// Token: 0x04009926 RID: 39206
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

				// Token: 0x04009927 RID: 39207
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009928 RID: 39208
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009929 RID: 39209
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400992A RID: 39210
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400992B RID: 39211
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400992C RID: 39212
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400992D RID: 39213
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
