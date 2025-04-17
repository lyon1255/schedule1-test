using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CA RID: 1738
	public class QualityFieldUI : MonoBehaviour
	{
		// Token: 0x06009C1D RID: 39965 RVA: 0x00278F50 File Offset: 0x00277150
		// Note: this type is marked as 'beforefieldinit'.
		static QualityFieldUI()
		{
			Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "QualityFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr);
			QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			QualityFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "FieldLabel");
			QualityFieldUI.NativeFieldInfoPtr_QualityButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "QualityButtons");
			QualityFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682462);
			QualityFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682463);
			QualityFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682464);
			QualityFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682465);
			QualityFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682466);
			QualityFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682467);
			QualityFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682468);
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x06009C1E RID: 39966 RVA: 0x00279048 File Offset: 0x00277248
		// (set) Token: 0x06009C1F RID: 39967 RVA: 0x00279088 File Offset: 0x00277288
		public unsafe List<QualityField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<QualityField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009C20 RID: 39968 RVA: 0x002790CC File Offset: 0x002772CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276965, RefRangeEnd = 276966, XrefRangeStart = 276924, XrefRangeEnd = 276965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<QualityField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C21 RID: 39969 RVA: 0x00279110 File Offset: 0x00277310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276980, RefRangeEnd = 276981, XrefRangeStart = 276966, XrefRangeEnd = 276980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C22 RID: 39970 RVA: 0x00279150 File Offset: 0x00277350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276981, XrefRangeEnd = 276988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009C23 RID: 39971 RVA: 0x0027918C File Offset: 0x0027738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276988, XrefRangeEnd = 276994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x002791CC File Offset: 0x002773CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276994, XrefRangeEnd = 277002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x0004C86D File Offset: 0x0004AA6D
		public QualityFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x06009C26 RID: 39974 RVA: 0x00279208 File Offset: 0x00277408
		// (set) Token: 0x06009C27 RID: 39975 RVA: 0x0004C876 File Offset: 0x0004AA76
		public unsafe List<QualityField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QualityField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x06009C28 RID: 39976 RVA: 0x00279238 File Offset: 0x00277438
		// (set) Token: 0x06009C29 RID: 39977 RVA: 0x0004C895 File Offset: 0x0004AA95
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x06009C2A RID: 39978 RVA: 0x00279268 File Offset: 0x00277468
		// (set) Token: 0x06009C2B RID: 39979 RVA: 0x0004C8B4 File Offset: 0x0004AAB4
		public unsafe Il2CppReferenceArray<Button> QualityButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_QualityButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_QualityButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068DE RID: 26846
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040068DF RID: 26847
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040068E0 RID: 26848
		private static readonly IntPtr NativeFieldInfoPtr_QualityButtons;

		// Token: 0x040068E1 RID: 26849
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0;

		// Token: 0x040068E2 RID: 26850
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0;

		// Token: 0x040068E3 RID: 26851
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0;

		// Token: 0x040068E4 RID: 26852
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0;

		// Token: 0x040068E5 RID: 26853
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068E6 RID: 26854
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0;

		// Token: 0x040068E7 RID: 26855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8D RID: 2957
		[ObfuscatedName("ScheduleOne.UI.Management.QualityFieldUI+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBDE RID: 56286 RVA: 0x003403C0 File Offset: 0x0033E5C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr);
				QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, "quality");
				QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, 100682469);
				QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, 100682470);
			}

			// Token: 0x0600DBDF RID: 56287 RVA: 0x0034043C File Offset: 0x0033E63C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBE0 RID: 56288 RVA: 0x00340478 File Offset: 0x0033E678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276918, XrefRangeEnd = 276924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Bind_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBE1 RID: 56289 RVA: 0x0006B1D2 File Offset: 0x000693D2
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700442C RID: 17452
			// (get) Token: 0x0600DBE2 RID: 56290 RVA: 0x003404AC File Offset: 0x0033E6AC
			// (set) Token: 0x0600DBE3 RID: 56291 RVA: 0x0006B1DB File Offset: 0x000693DB
			public unsafe EQuality quality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality)) = value;
				}
			}

			// Token: 0x1700442D RID: 17453
			// (get) Token: 0x0600DBE4 RID: 56292 RVA: 0x003404D4 File Offset: 0x0033E6D4
			// (set) Token: 0x0600DBE5 RID: 56293 RVA: 0x0006B1F6 File Offset: 0x000693F6
			public unsafe QualityFieldUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009369 RID: 37737
			private static readonly IntPtr NativeFieldInfoPtr_quality;

			// Token: 0x0400936A RID: 37738
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400936B RID: 37739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400936C RID: 37740
			private static readonly IntPtr NativeMethodInfoPtr__Bind_b__0_Internal_Void_0;
		}
	}
}
