using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000629 RID: 1577
	public class CanvasScaler : MonoBehaviour
	{
		// Token: 0x06008B0F RID: 35599 RVA: 0x002464DC File Offset: 0x002446DC
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasScaler()
		{
			Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CanvasScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr);
			CanvasScaler.NativeFieldInfoPtr_CanvasScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "CanvasScaleFactor");
			CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "OnCanvasScaleFactorChanged");
			CanvasScaler.NativeFieldInfoPtr_ScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "ScaleMultiplier");
			CanvasScaler.NativeFieldInfoPtr_referenceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "referenceResolution");
			CanvasScaler.NativeFieldInfoPtr_canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "canvasScaler");
			CanvasScaler.NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680573);
			CanvasScaler.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680574);
			CanvasScaler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680575);
			CanvasScaler.NativeMethodInfoPtr_RefreshScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680576);
			CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680577);
			CanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680578);
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x06008B10 RID: 35600 RVA: 0x002465E8 File Offset: 0x002447E8
		public unsafe static float NormalizedCanvasScaleFactor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 254694, RefRangeEnd = 254697, XrefRangeStart = 254690, XrefRangeEnd = 254694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x00246618 File Offset: 0x00244818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254697, XrefRangeEnd = 254727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x0024664C File Offset: 0x0024484C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254727, XrefRangeEnd = 254747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x00246680 File Offset: 0x00244880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254747, XrefRangeEnd = 254753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_RefreshScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x002466B4 File Offset: 0x002448B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254758, RefRangeEnd = 254760, XrefRangeStart = 254753, XrefRangeEnd = 254758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScaleFactor(float scaleFactor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scaleFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x002466E8 File Offset: 0x002448E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254760, XrefRangeEnd = 254761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x00042923 File Offset: 0x00040B23
		public CanvasScaler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x06008B17 RID: 35607 RVA: 0x00246724 File Offset: 0x00244924
		// (set) Token: 0x06008B18 RID: 35608 RVA: 0x0004292C File Offset: 0x00040B2C
		public unsafe static float CanvasScaleFactor
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr_CanvasScaleFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr_CanvasScaleFactor, (void*)(&value));
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x06008B19 RID: 35609 RVA: 0x00246740 File Offset: 0x00244940
		// (set) Token: 0x06008B1A RID: 35610 RVA: 0x0004293A File Offset: 0x00040B3A
		public unsafe static Action OnCanvasScaleFactorChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x06008B1B RID: 35611 RVA: 0x00246768 File Offset: 0x00244968
		// (set) Token: 0x06008B1C RID: 35612 RVA: 0x0004294C File Offset: 0x00040B4C
		public unsafe float ScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_ScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_ScaleMultiplier)) = value;
			}
		}

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x06008B1D RID: 35613 RVA: 0x00246790 File Offset: 0x00244990
		// (set) Token: 0x06008B1E RID: 35614 RVA: 0x00042967 File Offset: 0x00040B67
		public unsafe Vector2 referenceResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_referenceResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_referenceResolution)) = value;
			}
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x06008B1F RID: 35615 RVA: 0x002467B8 File Offset: 0x002449B8
		// (set) Token: 0x06008B20 RID: 35616 RVA: 0x00042982 File Offset: 0x00040B82
		public unsafe CanvasScaler canvasScaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_canvasScaler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasScaler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_canvasScaler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E4C RID: 24140
		private static readonly IntPtr NativeFieldInfoPtr_CanvasScaleFactor;

		// Token: 0x04005E4D RID: 24141
		private static readonly IntPtr NativeFieldInfoPtr_OnCanvasScaleFactorChanged;

		// Token: 0x04005E4E RID: 24142
		private static readonly IntPtr NativeFieldInfoPtr_ScaleMultiplier;

		// Token: 0x04005E4F RID: 24143
		private static readonly IntPtr NativeFieldInfoPtr_referenceResolution;

		// Token: 0x04005E50 RID: 24144
		private static readonly IntPtr NativeFieldInfoPtr_canvasScaler;

		// Token: 0x04005E51 RID: 24145
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0;

		// Token: 0x04005E52 RID: 24146
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04005E53 RID: 24147
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005E54 RID: 24148
		private static readonly IntPtr NativeMethodInfoPtr_RefreshScale_Private_Void_0;

		// Token: 0x04005E55 RID: 24149
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0;

		// Token: 0x04005E56 RID: 24150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
