using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Tooltips;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations.Drying_rack
{
	// Token: 0x02000682 RID: 1666
	public class DryingOperationUI : MonoBehaviour
	{
		// Token: 0x06009565 RID: 38245 RVA: 0x00264F30 File Offset: 0x00263130
		// Note: this type is marked as 'beforefieldinit'.
		static DryingOperationUI()
		{
			Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations.Drying_rack", "DryingOperationUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr);
			DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "<AssignedOperation>k__BackingField");
			DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "<Alignment>k__BackingField");
			DryingOperationUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Rect");
			DryingOperationUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Icon");
			DryingOperationUI.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "QuantityLabel");
			DryingOperationUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Button");
			DryingOperationUI.NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Tooltip");
			DryingOperationUI.NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681763);
			DryingOperationUI.NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681764);
			DryingOperationUI.NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681765);
			DryingOperationUI.NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681766);
			DryingOperationUI.NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681767);
			DryingOperationUI.NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681768);
			DryingOperationUI.NativeMethodInfoPtr_RefreshQuantity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681769);
			DryingOperationUI.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681770);
			DryingOperationUI.NativeMethodInfoPtr_UpdatePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681771);
			DryingOperationUI.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681772);
			DryingOperationUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681773);
			DryingOperationUI.NativeMethodInfoPtr__Start_b__16_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681774);
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x06009566 RID: 38246 RVA: 0x002650DC File Offset: 0x002632DC
		// (set) Token: 0x06009567 RID: 38247 RVA: 0x0026511C File Offset: 0x0026331C
		public unsafe DryingOperation AssignedOperation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x06009568 RID: 38248 RVA: 0x00265160 File Offset: 0x00263360
		// (set) Token: 0x06009569 RID: 38249 RVA: 0x002651A0 File Offset: 0x002633A0
		public unsafe RectTransform Alignment
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x002651E4 File Offset: 0x002633E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268442, XrefRangeEnd = 268448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOperation(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x00265228 File Offset: 0x00263428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268453, RefRangeEnd = 268454, XrefRangeStart = 268448, XrefRangeEnd = 268453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlignment(RectTransform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x0026526C File Offset: 0x0026346C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268459, RefRangeEnd = 268462, XrefRangeStart = 268454, XrefRangeEnd = 268459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_RefreshQuantity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x002652A0 File Offset: 0x002634A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268462, XrefRangeEnd = 268470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x002652D4 File Offset: 0x002634D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 268482, RefRangeEnd = 268486, XrefRangeStart = 268470, XrefRangeEnd = 268482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_UpdatePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600956F RID: 38255 RVA: 0x00265308 File Offset: 0x00263508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268486, XrefRangeEnd = 268499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009570 RID: 38256 RVA: 0x0026533C File Offset: 0x0026353C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperationUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009571 RID: 38257 RVA: 0x00265378 File Offset: 0x00263578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__16_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr__Start_b__16_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009572 RID: 38258 RVA: 0x00048A5A File Offset: 0x00046C5A
		public DryingOperationUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x06009573 RID: 38259 RVA: 0x002653AC File Offset: 0x002635AC
		// (set) Token: 0x06009574 RID: 38260 RVA: 0x00048A63 File Offset: 0x00046C63
		public unsafe DryingOperation _AssignedOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x06009575 RID: 38261 RVA: 0x002653DC File Offset: 0x002635DC
		// (set) Token: 0x06009576 RID: 38262 RVA: 0x00048A82 File Offset: 0x00046C82
		public unsafe RectTransform _Alignment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x06009577 RID: 38263 RVA: 0x0026540C File Offset: 0x0026360C
		// (set) Token: 0x06009578 RID: 38264 RVA: 0x00048AA1 File Offset: 0x00046CA1
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x06009579 RID: 38265 RVA: 0x0026543C File Offset: 0x0026363C
		// (set) Token: 0x0600957A RID: 38266 RVA: 0x00048AC0 File Offset: 0x00046CC0
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600957B RID: 38267 RVA: 0x0026546C File Offset: 0x0026366C
		// (set) Token: 0x0600957C RID: 38268 RVA: 0x00048ADF File Offset: 0x00046CDF
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600957D RID: 38269 RVA: 0x0026549C File Offset: 0x0026369C
		// (set) Token: 0x0600957E RID: 38270 RVA: 0x00048AFE File Offset: 0x00046CFE
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0600957F RID: 38271 RVA: 0x002654CC File Offset: 0x002636CC
		// (set) Token: 0x06009580 RID: 38272 RVA: 0x00048B1D File Offset: 0x00046D1D
		public unsafe Tooltip Tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Tooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Tooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064BF RID: 25791
		private static readonly IntPtr NativeFieldInfoPtr__AssignedOperation_k__BackingField;

		// Token: 0x040064C0 RID: 25792
		private static readonly IntPtr NativeFieldInfoPtr__Alignment_k__BackingField;

		// Token: 0x040064C1 RID: 25793
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040064C2 RID: 25794
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x040064C3 RID: 25795
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x040064C4 RID: 25796
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040064C5 RID: 25797
		private static readonly IntPtr NativeFieldInfoPtr_Tooltip;

		// Token: 0x040064C6 RID: 25798
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0;

		// Token: 0x040064C7 RID: 25799
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0;

		// Token: 0x040064C8 RID: 25800
		private static readonly IntPtr NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0;

		// Token: 0x040064C9 RID: 25801
		private static readonly IntPtr NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0;

		// Token: 0x040064CA RID: 25802
		private static readonly IntPtr NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0;

		// Token: 0x040064CB RID: 25803
		private static readonly IntPtr NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0;

		// Token: 0x040064CC RID: 25804
		private static readonly IntPtr NativeMethodInfoPtr_RefreshQuantity_Public_Void_0;

		// Token: 0x040064CD RID: 25805
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040064CE RID: 25806
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_0;

		// Token: 0x040064CF RID: 25807
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x040064D0 RID: 25808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040064D1 RID: 25809
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__16_0_Private_Void_0;
	}
}
