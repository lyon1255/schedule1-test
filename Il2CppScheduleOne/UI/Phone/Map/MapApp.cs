using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Map
{
	// Token: 0x020006A8 RID: 1704
	public class MapApp : App<MapApp>
	{
		// Token: 0x06009894 RID: 39060 RVA: 0x0026EDA0 File Offset: 0x0026CFA0
		// Note: this type is marked as 'beforefieldinit'.
		static MapApp()
		{
			Il2CppClassPointerStore<MapApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Map", "MapApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapApp>.NativeClassPtr);
			MapApp.NativeFieldInfoPtr_KeyMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "KeyMoveSpeed");
			MapApp.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "ContentRect");
			MapApp.NativeFieldInfoPtr_PoIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "PoIContainer");
			MapApp.NativeFieldInfoPtr_HorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "HorizontalScrollbar");
			MapApp.NativeFieldInfoPtr_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "VerticalScrollbar");
			MapApp.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "BackgroundImage");
			MapApp.NativeFieldInfoPtr_LabelGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelGroup");
			MapApp.NativeFieldInfoPtr_DemoMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "DemoMapSprite");
			MapApp.NativeFieldInfoPtr_MainMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "MainMapSprite");
			MapApp.NativeFieldInfoPtr_TutorialMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "TutorialMapSprite");
			MapApp.NativeFieldInfoPtr_LabelScrollMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelScrollMin");
			MapApp.NativeFieldInfoPtr_LabelScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelScrollMax");
			MapApp.NativeFieldInfoPtr_SkipFocusPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "SkipFocusPlayer");
			MapApp.NativeFieldInfoPtr_contentMoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "contentMoveRoutine");
			MapApp.NativeFieldInfoPtr_opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "opened");
			MapApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682138);
			MapApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682139);
			MapApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682140);
			MapApp.NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682141);
			MapApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682142);
		}

		// Token: 0x06009895 RID: 39061 RVA: 0x0026EF60 File Offset: 0x0026D160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272437, XrefRangeEnd = 272448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009896 RID: 39062 RVA: 0x0026EF9C File Offset: 0x0026D19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272448, XrefRangeEnd = 272492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009897 RID: 39063 RVA: 0x0026EFE8 File Offset: 0x0026D1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272492, XrefRangeEnd = 272505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x0026F024 File Offset: 0x0026D224
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 272511, RefRangeEnd = 272515, XrefRangeStart = 272505, XrefRangeEnd = 272511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusPosition(Vector2 anchoredPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref anchoredPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x0026F064 File Offset: 0x0026D264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272515, XrefRangeEnd = 272521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x0004A4F9 File Offset: 0x000486F9
		public MapApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0600989B RID: 39067 RVA: 0x0026F0A0 File Offset: 0x0026D2A0
		// (set) Token: 0x0600989C RID: 39068 RVA: 0x0004A502 File Offset: 0x00048702
		public unsafe static float KeyMoveSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapApp.NativeFieldInfoPtr_KeyMoveSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapApp.NativeFieldInfoPtr_KeyMoveSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x0600989D RID: 39069 RVA: 0x0026F0BC File Offset: 0x0026D2BC
		// (set) Token: 0x0600989E RID: 39070 RVA: 0x0004A510 File Offset: 0x00048710
		public unsafe RectTransform ContentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_ContentRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0600989F RID: 39071 RVA: 0x0026F0EC File Offset: 0x0026D2EC
		// (set) Token: 0x060098A0 RID: 39072 RVA: 0x0004A52F File Offset: 0x0004872F
		public unsafe RectTransform PoIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_PoIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_PoIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x060098A1 RID: 39073 RVA: 0x0026F11C File Offset: 0x0026D31C
		// (set) Token: 0x060098A2 RID: 39074 RVA: 0x0004A54E File Offset: 0x0004874E
		public unsafe Scrollbar HorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_HorizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_HorizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x060098A3 RID: 39075 RVA: 0x0026F14C File Offset: 0x0026D34C
		// (set) Token: 0x060098A4 RID: 39076 RVA: 0x0004A56D File Offset: 0x0004876D
		public unsafe Scrollbar VerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_VerticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x060098A5 RID: 39077 RVA: 0x0026F17C File Offset: 0x0026D37C
		// (set) Token: 0x060098A6 RID: 39078 RVA: 0x0004A58C File Offset: 0x0004878C
		public unsafe Image BackgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_BackgroundImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x060098A7 RID: 39079 RVA: 0x0026F1AC File Offset: 0x0026D3AC
		// (set) Token: 0x060098A8 RID: 39080 RVA: 0x0004A5AB File Offset: 0x000487AB
		public unsafe CanvasGroup LabelGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x060098A9 RID: 39081 RVA: 0x0026F1DC File Offset: 0x0026D3DC
		// (set) Token: 0x060098AA RID: 39082 RVA: 0x0004A5CA File Offset: 0x000487CA
		public unsafe Sprite DemoMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_DemoMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_DemoMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x060098AB RID: 39083 RVA: 0x0026F20C File Offset: 0x0026D40C
		// (set) Token: 0x060098AC RID: 39084 RVA: 0x0004A5E9 File Offset: 0x000487E9
		public unsafe Sprite MainMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_MainMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_MainMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x060098AD RID: 39085 RVA: 0x0026F23C File Offset: 0x0026D43C
		// (set) Token: 0x060098AE RID: 39086 RVA: 0x0004A608 File Offset: 0x00048808
		public unsafe Sprite TutorialMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_TutorialMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_TutorialMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x060098AF RID: 39087 RVA: 0x0026F26C File Offset: 0x0026D46C
		// (set) Token: 0x060098B0 RID: 39088 RVA: 0x0004A627 File Offset: 0x00048827
		public unsafe float LabelScrollMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMin)) = value;
			}
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x060098B1 RID: 39089 RVA: 0x0026F294 File Offset: 0x0026D494
		// (set) Token: 0x060098B2 RID: 39090 RVA: 0x0004A642 File Offset: 0x00048842
		public unsafe float LabelScrollMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMax)) = value;
			}
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x060098B3 RID: 39091 RVA: 0x0026F2BC File Offset: 0x0026D4BC
		// (set) Token: 0x060098B4 RID: 39092 RVA: 0x0004A65D File Offset: 0x0004885D
		public unsafe bool SkipFocusPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_SkipFocusPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_SkipFocusPlayer)) = value;
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x060098B5 RID: 39093 RVA: 0x0026F2E4 File Offset: 0x0026D4E4
		// (set) Token: 0x060098B6 RID: 39094 RVA: 0x0004A678 File Offset: 0x00048878
		public unsafe Coroutine contentMoveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_contentMoveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_contentMoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x060098B7 RID: 39095 RVA: 0x0026F314 File Offset: 0x0026D514
		// (set) Token: 0x060098B8 RID: 39096 RVA: 0x0004A697 File Offset: 0x00048897
		public unsafe bool opened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_opened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_opened)) = value;
			}
		}

		// Token: 0x040066C2 RID: 26306
		private static readonly IntPtr NativeFieldInfoPtr_KeyMoveSpeed;

		// Token: 0x040066C3 RID: 26307
		private static readonly IntPtr NativeFieldInfoPtr_ContentRect;

		// Token: 0x040066C4 RID: 26308
		private static readonly IntPtr NativeFieldInfoPtr_PoIContainer;

		// Token: 0x040066C5 RID: 26309
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalScrollbar;

		// Token: 0x040066C6 RID: 26310
		private static readonly IntPtr NativeFieldInfoPtr_VerticalScrollbar;

		// Token: 0x040066C7 RID: 26311
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundImage;

		// Token: 0x040066C8 RID: 26312
		private static readonly IntPtr NativeFieldInfoPtr_LabelGroup;

		// Token: 0x040066C9 RID: 26313
		private static readonly IntPtr NativeFieldInfoPtr_DemoMapSprite;

		// Token: 0x040066CA RID: 26314
		private static readonly IntPtr NativeFieldInfoPtr_MainMapSprite;

		// Token: 0x040066CB RID: 26315
		private static readonly IntPtr NativeFieldInfoPtr_TutorialMapSprite;

		// Token: 0x040066CC RID: 26316
		private static readonly IntPtr NativeFieldInfoPtr_LabelScrollMin;

		// Token: 0x040066CD RID: 26317
		private static readonly IntPtr NativeFieldInfoPtr_LabelScrollMax;

		// Token: 0x040066CE RID: 26318
		private static readonly IntPtr NativeFieldInfoPtr_SkipFocusPlayer;

		// Token: 0x040066CF RID: 26319
		private static readonly IntPtr NativeFieldInfoPtr_contentMoveRoutine;

		// Token: 0x040066D0 RID: 26320
		private static readonly IntPtr NativeFieldInfoPtr_opened;

		// Token: 0x040066D1 RID: 26321
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040066D2 RID: 26322
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040066D3 RID: 26323
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040066D4 RID: 26324
		private static readonly IntPtr NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0;

		// Token: 0x040066D5 RID: 26325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
