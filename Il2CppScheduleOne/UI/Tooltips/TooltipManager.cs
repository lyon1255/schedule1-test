using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Tooltips
{
	// Token: 0x02000679 RID: 1657
	public class TooltipManager : Singleton<TooltipManager>
	{
		// Token: 0x060093ED RID: 37869 RVA: 0x002607A0 File Offset: 0x0025E9A0
		// Note: this type is marked as 'beforefieldinit'.
		static TooltipManager()
		{
			Il2CppClassPointerStore<TooltipManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Tooltips", "TooltipManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr);
			TooltipManager.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "anchor");
			TooltipManager.NativeFieldInfoPtr_tooltipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "tooltipLabel");
			TooltipManager.NativeFieldInfoPtr_canvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "canvases");
			TooltipManager.NativeFieldInfoPtr_sortedCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "sortedCanvases");
			TooltipManager.NativeFieldInfoPtr_raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "raycasters");
			TooltipManager.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "eventSystem");
			TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "tooltipShownThisFrame");
			TooltipManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681623);
			TooltipManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681624);
			TooltipManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681625);
			TooltipManager.NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681626);
			TooltipManager.NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681627);
			TooltipManager.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681628);
			TooltipManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681629);
		}

		// Token: 0x060093EE RID: 37870 RVA: 0x002608E8 File Offset: 0x0025EAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265908, XrefRangeEnd = 265984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x00260924 File Offset: 0x0025EB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265984, XrefRangeEnd = 265985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x00260960 File Offset: 0x0025EB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265985, XrefRangeEnd = 265987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093F1 RID: 37873 RVA: 0x0026099C File Offset: 0x0025EB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266062, RefRangeEnd = 266063, XrefRangeStart = 265987, XrefRangeEnd = 266062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCanvas(Canvas canvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093F2 RID: 37874 RVA: 0x002609E0 File Offset: 0x0025EBE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266106, RefRangeEnd = 266107, XrefRangeStart = 266063, XrefRangeEnd = 266106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForTooltipHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093F3 RID: 37875 RVA: 0x00260A14 File Offset: 0x0025EC14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266154, RefRangeEnd = 266155, XrefRangeStart = 266107, XrefRangeEnd = 266154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTooltip(string text, Vector2 position, bool worldspace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldspace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093F4 RID: 37876 RVA: 0x00260A74 File Offset: 0x0025EC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266155, XrefRangeEnd = 266177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TooltipManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093F5 RID: 37877 RVA: 0x00047BF6 File Offset: 0x00045DF6
		public TooltipManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x060093F6 RID: 37878 RVA: 0x00260AB0 File Offset: 0x0025ECB0
		// (set) Token: 0x060093F7 RID: 37879 RVA: 0x00047BFF File Offset: 0x00045DFF
		public unsafe RectTransform anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x060093F8 RID: 37880 RVA: 0x00260AE0 File Offset: 0x0025ECE0
		// (set) Token: 0x060093F9 RID: 37881 RVA: 0x00047C1E File Offset: 0x00045E1E
		public unsafe TextMeshProUGUI tooltipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x060093FA RID: 37882 RVA: 0x00260B10 File Offset: 0x0025ED10
		// (set) Token: 0x060093FB RID: 37883 RVA: 0x00047C3D File Offset: 0x00045E3D
		public unsafe List<Canvas> canvases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_canvases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Canvas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_canvases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x060093FC RID: 37884 RVA: 0x00260B40 File Offset: 0x0025ED40
		// (set) Token: 0x060093FD RID: 37885 RVA: 0x00047C5C File Offset: 0x00045E5C
		public unsafe List<Canvas> sortedCanvases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_sortedCanvases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Canvas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_sortedCanvases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x060093FE RID: 37886 RVA: 0x00260B70 File Offset: 0x0025ED70
		// (set) Token: 0x060093FF RID: 37887 RVA: 0x00047C7B File Offset: 0x00045E7B
		public unsafe List<GraphicRaycaster> raycasters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_raycasters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GraphicRaycaster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_raycasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x06009400 RID: 37888 RVA: 0x00260BA0 File Offset: 0x0025EDA0
		// (set) Token: 0x06009401 RID: 37889 RVA: 0x00047C9A File Offset: 0x00045E9A
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x06009402 RID: 37890 RVA: 0x00260BD0 File Offset: 0x0025EDD0
		// (set) Token: 0x06009403 RID: 37891 RVA: 0x00047CB9 File Offset: 0x00045EB9
		public unsafe bool tooltipShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame)) = value;
			}
		}

		// Token: 0x040063D0 RID: 25552
		private static readonly IntPtr NativeFieldInfoPtr_anchor;

		// Token: 0x040063D1 RID: 25553
		private static readonly IntPtr NativeFieldInfoPtr_tooltipLabel;

		// Token: 0x040063D2 RID: 25554
		private static readonly IntPtr NativeFieldInfoPtr_canvases;

		// Token: 0x040063D3 RID: 25555
		private static readonly IntPtr NativeFieldInfoPtr_sortedCanvases;

		// Token: 0x040063D4 RID: 25556
		private static readonly IntPtr NativeFieldInfoPtr_raycasters;

		// Token: 0x040063D5 RID: 25557
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x040063D6 RID: 25558
		private static readonly IntPtr NativeFieldInfoPtr_tooltipShownThisFrame;

		// Token: 0x040063D7 RID: 25559
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040063D8 RID: 25560
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040063D9 RID: 25561
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040063DA RID: 25562
		private static readonly IntPtr NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0;

		// Token: 0x040063DB RID: 25563
		private static readonly IntPtr NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0;

		// Token: 0x040063DC RID: 25564
		private static readonly IntPtr NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_0;

		// Token: 0x040063DD RID: 25565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B58 RID: 2904
		[ObfuscatedName("ScheduleOne.UI.Tooltips.TooltipManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA00 RID: 55808 RVA: 0x0033B09C File Offset: 0x0033929C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr);
				TooltipManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9");
				TooltipManager.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__7_0");
				TooltipManager.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__7_1");
				TooltipManager.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__7_2");
				TooltipManager.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__10_0");
				TooltipManager.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__10_1");
				TooltipManager.__c.NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__10_2");
				TooltipManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681631);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_0_Internal_Boolean_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681632);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_1_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681633);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_2_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681634);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_0_Internal_Boolean_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681635);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_1_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681636);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_2_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681637);
			}

			// Token: 0x0600DA01 RID: 55809 RVA: 0x0033B1E0 File Offset: 0x003393E0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA02 RID: 55810 RVA: 0x0033B21C File Offset: 0x0033941C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265890, XrefRangeEnd = 265898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__7_0(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_0_Internal_Boolean_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA03 RID: 55811 RVA: 0x0033B26C File Offset: 0x0033946C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265898, XrefRangeEnd = 265900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Awake_b__7_1(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_1_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA04 RID: 55812 RVA: 0x0033B2BC File Offset: 0x003394BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265900, XrefRangeEnd = 265903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Awake_b__7_2(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_2_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA05 RID: 55813 RVA: 0x0033B30C File Offset: 0x0033950C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265903, XrefRangeEnd = 265908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCanvas_b__10_0(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_0_Internal_Boolean_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA06 RID: 55814 RVA: 0x0033B35C File Offset: 0x0033955C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddCanvas_b__10_1(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_1_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA07 RID: 55815 RVA: 0x0033B3AC File Offset: 0x003395AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddCanvas_b__10_2(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_2_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA08 RID: 55816 RVA: 0x0006A2D0 File Offset: 0x000684D0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A4 RID: 17316
			// (get) Token: 0x0600DA09 RID: 55817 RVA: 0x0033B3FC File Offset: 0x003395FC
			// (set) Token: 0x0600DA0A RID: 55818 RVA: 0x0006A2D9 File Offset: 0x000684D9
			public unsafe static TooltipManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TooltipManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A5 RID: 17317
			// (get) Token: 0x0600DA0B RID: 55819 RVA: 0x0033B424 File Offset: 0x00339624
			// (set) Token: 0x0600DA0C RID: 55820 RVA: 0x0006A2EB File Offset: 0x000684EB
			public unsafe static Func<Canvas, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A6 RID: 17318
			// (get) Token: 0x0600DA0D RID: 55821 RVA: 0x0033B44C File Offset: 0x0033964C
			// (set) Token: 0x0600DA0E RID: 55822 RVA: 0x0006A2FD File Offset: 0x000684FD
			public unsafe static Func<Canvas, int> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A7 RID: 17319
			// (get) Token: 0x0600DA0F RID: 55823 RVA: 0x0033B474 File Offset: 0x00339674
			// (set) Token: 0x0600DA10 RID: 55824 RVA: 0x0006A30F File Offset: 0x0006850F
			public unsafe static Func<Canvas, int> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A8 RID: 17320
			// (get) Token: 0x0600DA11 RID: 55825 RVA: 0x0033B49C File Offset: 0x0033969C
			// (set) Token: 0x0600DA12 RID: 55826 RVA: 0x0006A321 File Offset: 0x00068521
			public unsafe static Func<Canvas, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A9 RID: 17321
			// (get) Token: 0x0600DA13 RID: 55827 RVA: 0x0033B4C4 File Offset: 0x003396C4
			// (set) Token: 0x0600DA14 RID: 55828 RVA: 0x0006A333 File Offset: 0x00068533
			public unsafe static Func<Canvas, int> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AA RID: 17322
			// (get) Token: 0x0600DA15 RID: 55829 RVA: 0x0033B4EC File Offset: 0x003396EC
			// (set) Token: 0x0600DA16 RID: 55830 RVA: 0x0006A345 File Offset: 0x00068545
			public unsafe static Func<Canvas, int> __9__10_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009262 RID: 37474
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009263 RID: 37475
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04009264 RID: 37476
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04009265 RID: 37477
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x04009266 RID: 37478
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04009267 RID: 37479
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04009268 RID: 37480
			private static readonly IntPtr NativeFieldInfoPtr___9__10_2;

			// Token: 0x04009269 RID: 37481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400926A RID: 37482
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_0_Internal_Boolean_Canvas_0;

			// Token: 0x0400926B RID: 37483
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_1_Internal_Int32_Canvas_0;

			// Token: 0x0400926C RID: 37484
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_2_Internal_Int32_Canvas_0;

			// Token: 0x0400926D RID: 37485
			private static readonly IntPtr NativeMethodInfoPtr__AddCanvas_b__10_0_Internal_Boolean_Canvas_0;

			// Token: 0x0400926E RID: 37486
			private static readonly IntPtr NativeMethodInfoPtr__AddCanvas_b__10_1_Internal_Int32_Canvas_0;

			// Token: 0x0400926F RID: 37487
			private static readonly IntPtr NativeMethodInfoPtr__AddCanvas_b__10_2_Internal_Int32_Canvas_0;
		}
	}
}
