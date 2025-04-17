using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000656 RID: 1622
	public class EyelidOverlay : Singleton<EyelidOverlay>
	{
		// Token: 0x060090CC RID: 37068 RVA: 0x00257504 File Offset: 0x00255704
		// Note: this type is marked as 'beforefieldinit'.
		static EyelidOverlay()
		{
			Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "EyelidOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr);
			EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "MaxTiredOpenAmount");
			EyelidOverlay.NativeFieldInfoPtr_AutoUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "AutoUpdate");
			EyelidOverlay.NativeFieldInfoPtr_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Open");
			EyelidOverlay.NativeFieldInfoPtr_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Closed");
			EyelidOverlay.NativeFieldInfoPtr_Upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Upper");
			EyelidOverlay.NativeFieldInfoPtr_Lower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Lower");
			EyelidOverlay.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Canvas");
			EyelidOverlay.NativeFieldInfoPtr_CurrentOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "CurrentOpen");
			EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "OpenMultiplier");
			EyelidOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681239);
			EyelidOverlay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681240);
			EyelidOverlay.NativeMethodInfoPtr_SetOpen_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681241);
			EyelidOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681242);
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x00257638 File Offset: 0x00255838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262028, XrefRangeEnd = 262034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyelidOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x00257674 File Offset: 0x00255874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262034, XrefRangeEnd = 262050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x002576A8 File Offset: 0x002558A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262056, RefRangeEnd = 262061, XrefRangeStart = 262050, XrefRangeEnd = 262056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(float openness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr_SetOpen_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x002576E8 File Offset: 0x002558E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262061, XrefRangeEnd = 262064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyelidOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x00045F3C File Offset: 0x0004413C
		public EyelidOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x060090D2 RID: 37074 RVA: 0x00257724 File Offset: 0x00255924
		// (set) Token: 0x060090D3 RID: 37075 RVA: 0x00045F45 File Offset: 0x00044145
		public unsafe static float MaxTiredOpenAmount
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount, (void*)(&value));
			}
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x060090D4 RID: 37076 RVA: 0x00257740 File Offset: 0x00255940
		// (set) Token: 0x060090D5 RID: 37077 RVA: 0x00045F53 File Offset: 0x00044153
		public unsafe bool AutoUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_AutoUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_AutoUpdate)) = value;
			}
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x060090D6 RID: 37078 RVA: 0x00257768 File Offset: 0x00255968
		// (set) Token: 0x060090D7 RID: 37079 RVA: 0x00045F6E File Offset: 0x0004416E
		public unsafe float Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Open)) = value;
			}
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x060090D8 RID: 37080 RVA: 0x00257790 File Offset: 0x00255990
		// (set) Token: 0x060090D9 RID: 37081 RVA: 0x00045F89 File Offset: 0x00044189
		public unsafe float Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Closed)) = value;
			}
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x060090DA RID: 37082 RVA: 0x002577B8 File Offset: 0x002559B8
		// (set) Token: 0x060090DB RID: 37083 RVA: 0x00045FA4 File Offset: 0x000441A4
		public unsafe RectTransform Upper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Upper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Upper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x060090DC RID: 37084 RVA: 0x002577E8 File Offset: 0x002559E8
		// (set) Token: 0x060090DD RID: 37085 RVA: 0x00045FC3 File Offset: 0x000441C3
		public unsafe RectTransform Lower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Lower);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Lower), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x060090DE RID: 37086 RVA: 0x00257818 File Offset: 0x00255A18
		// (set) Token: 0x060090DF RID: 37087 RVA: 0x00045FE2 File Offset: 0x000441E2
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x060090E0 RID: 37088 RVA: 0x00257848 File Offset: 0x00255A48
		// (set) Token: 0x060090E1 RID: 37089 RVA: 0x00046001 File Offset: 0x00044201
		public unsafe float CurrentOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_CurrentOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_CurrentOpen)) = value;
			}
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x060090E2 RID: 37090 RVA: 0x00257870 File Offset: 0x00255A70
		// (set) Token: 0x060090E3 RID: 37091 RVA: 0x0004601C File Offset: 0x0004421C
		public unsafe FloatSmoother OpenMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040061E6 RID: 25062
		private static readonly IntPtr NativeFieldInfoPtr_MaxTiredOpenAmount;

		// Token: 0x040061E7 RID: 25063
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdate;

		// Token: 0x040061E8 RID: 25064
		private static readonly IntPtr NativeFieldInfoPtr_Open;

		// Token: 0x040061E9 RID: 25065
		private static readonly IntPtr NativeFieldInfoPtr_Closed;

		// Token: 0x040061EA RID: 25066
		private static readonly IntPtr NativeFieldInfoPtr_Upper;

		// Token: 0x040061EB RID: 25067
		private static readonly IntPtr NativeFieldInfoPtr_Lower;

		// Token: 0x040061EC RID: 25068
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040061ED RID: 25069
		private static readonly IntPtr NativeFieldInfoPtr_CurrentOpen;

		// Token: 0x040061EE RID: 25070
		private static readonly IntPtr NativeFieldInfoPtr_OpenMultiplier;

		// Token: 0x040061EF RID: 25071
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040061F0 RID: 25072
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040061F1 RID: 25073
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Single_0;

		// Token: 0x040061F2 RID: 25074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
