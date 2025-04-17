using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000655 RID: 1621
	public class DeathScreen : Singleton<DeathScreen>
	{
		// Token: 0x060090AD RID: 37037 RVA: 0x00256F24 File Offset: 0x00255124
		// Note: this type is marked as 'beforefieldinit'.
		static DeathScreen()
		{
			Il2CppClassPointerStore<DeathScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DeathScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr);
			DeathScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			DeathScreen.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "canvas");
			DeathScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "Container");
			DeathScreen.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "group");
			DeathScreen.NativeFieldInfoPtr_respawnButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "respawnButton");
			DeathScreen.NativeFieldInfoPtr_loadSaveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "loadSaveButton");
			DeathScreen.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "Anim");
			DeathScreen.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "Sound");
			DeathScreen.NativeFieldInfoPtr_arrested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "arrested");
			DeathScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681216);
			DeathScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681217);
			DeathScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681218);
			DeathScreen.NativeMethodInfoPtr_RespawnClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681219);
			DeathScreen.NativeMethodInfoPtr_LoadSaveClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681220);
			DeathScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681221);
			DeathScreen.NativeMethodInfoPtr_CanRespawn_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681222);
			DeathScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681223);
			DeathScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681224);
			DeathScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681225);
			DeathScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, 100681226);
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x060090AE RID: 37038 RVA: 0x002570E4 File Offset: 0x002552E4
		// (set) Token: 0x060090AF RID: 37039 RVA: 0x00257120 File Offset: 0x00255320
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060090B0 RID: 37040 RVA: 0x00257160 File Offset: 0x00255360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261928, XrefRangeEnd = 261950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeathScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090B1 RID: 37041 RVA: 0x0025719C File Offset: 0x0025539C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261950, XrefRangeEnd = 261956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RespawnClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr_RespawnClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090B2 RID: 37042 RVA: 0x002571D0 File Offset: 0x002553D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261956, XrefRangeEnd = 261965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSaveClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr_LoadSaveClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090B3 RID: 37043 RVA: 0x00257204 File Offset: 0x00255404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261992, RefRangeEnd = 261993, XrefRangeStart = 261965, XrefRangeEnd = 261992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090B4 RID: 37044 RVA: 0x00257238 File Offset: 0x00255438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261993, XrefRangeEnd = 261998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanRespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr_CanRespawn_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060090B5 RID: 37045 RVA: 0x00257274 File Offset: 0x00255474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262013, RefRangeEnd = 262015, XrefRangeStart = 261998, XrefRangeEnd = 262013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090B6 RID: 37046 RVA: 0x002572A8 File Offset: 0x002554A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262015, XrefRangeEnd = 262018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeathScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090B7 RID: 37047 RVA: 0x002572E4 File Offset: 0x002554E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262018, XrefRangeEnd = 262023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060090B8 RID: 37048 RVA: 0x00257324 File Offset: 0x00255524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262023, XrefRangeEnd = 262028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060090B9 RID: 37049 RVA: 0x00045E24 File Offset: 0x00044024
		public DeathScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x060090BA RID: 37050 RVA: 0x00257364 File Offset: 0x00255564
		// (set) Token: 0x060090BB RID: 37051 RVA: 0x00045E2D File Offset: 0x0004402D
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x060090BC RID: 37052 RVA: 0x0025738C File Offset: 0x0025558C
		// (set) Token: 0x060090BD RID: 37053 RVA: 0x00045E48 File Offset: 0x00044048
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x060090BE RID: 37054 RVA: 0x002573BC File Offset: 0x002555BC
		// (set) Token: 0x060090BF RID: 37055 RVA: 0x00045E67 File Offset: 0x00044067
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x060090C0 RID: 37056 RVA: 0x002573EC File Offset: 0x002555EC
		// (set) Token: 0x060090C1 RID: 37057 RVA: 0x00045E86 File Offset: 0x00044086
		public unsafe CanvasGroup group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x060090C2 RID: 37058 RVA: 0x0025741C File Offset: 0x0025561C
		// (set) Token: 0x060090C3 RID: 37059 RVA: 0x00045EA5 File Offset: 0x000440A5
		public unsafe Button respawnButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_respawnButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_respawnButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x060090C4 RID: 37060 RVA: 0x0025744C File Offset: 0x0025564C
		// (set) Token: 0x060090C5 RID: 37061 RVA: 0x00045EC4 File Offset: 0x000440C4
		public unsafe Button loadSaveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_loadSaveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_loadSaveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x060090C6 RID: 37062 RVA: 0x0025747C File Offset: 0x0025567C
		// (set) Token: 0x060090C7 RID: 37063 RVA: 0x00045EE3 File Offset: 0x000440E3
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x060090C8 RID: 37064 RVA: 0x002574AC File Offset: 0x002556AC
		// (set) Token: 0x060090C9 RID: 37065 RVA: 0x00045F02 File Offset: 0x00044102
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x060090CA RID: 37066 RVA: 0x002574DC File Offset: 0x002556DC
		// (set) Token: 0x060090CB RID: 37067 RVA: 0x00045F21 File Offset: 0x00044121
		public unsafe bool arrested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_arrested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.NativeFieldInfoPtr_arrested)) = value;
			}
		}

		// Token: 0x040061D2 RID: 25042
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040061D3 RID: 25043
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040061D4 RID: 25044
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040061D5 RID: 25045
		private static readonly IntPtr NativeFieldInfoPtr_group;

		// Token: 0x040061D6 RID: 25046
		private static readonly IntPtr NativeFieldInfoPtr_respawnButton;

		// Token: 0x040061D7 RID: 25047
		private static readonly IntPtr NativeFieldInfoPtr_loadSaveButton;

		// Token: 0x040061D8 RID: 25048
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040061D9 RID: 25049
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x040061DA RID: 25050
		private static readonly IntPtr NativeFieldInfoPtr_arrested;

		// Token: 0x040061DB RID: 25051
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040061DC RID: 25052
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040061DD RID: 25053
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040061DE RID: 25054
		private static readonly IntPtr NativeMethodInfoPtr_RespawnClicked_Private_Void_0;

		// Token: 0x040061DF RID: 25055
		private static readonly IntPtr NativeMethodInfoPtr_LoadSaveClicked_Private_Void_0;

		// Token: 0x040061E0 RID: 25056
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040061E1 RID: 25057
		private static readonly IntPtr NativeMethodInfoPtr_CanRespawn_Private_Boolean_0;

		// Token: 0x040061E2 RID: 25058
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040061E3 RID: 25059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040061E4 RID: 25060
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040061E5 RID: 25061
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000B3D RID: 2877
		[ObfuscatedName("ScheduleOne.UI.DeathScreen+<<Open>g__Routine|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D88C RID: 55436 RVA: 0x00336B58 File Offset: 0x00334D58
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique()
			{
				Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "<<Open>g__Routine|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, "<>1__state");
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, "<>2__current");
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, "<>4__this");
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, 100681227);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, 100681228);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, 100681229);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, 100681230);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, 100681231);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr, 100681232);
			}

			// Token: 0x0600D88D RID: 55437 RVA: 0x00336C60 File Offset: 0x00334E60
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D88E RID: 55438 RVA: 0x00336CA8 File Offset: 0x00334EA8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D88F RID: 55439 RVA: 0x00336CDC File Offset: 0x00334EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261833, XrefRangeEnd = 261850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700432C RID: 17196
			// (get) Token: 0x0600D890 RID: 55440 RVA: 0x00336D18 File Offset: 0x00334F18
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D891 RID: 55441 RVA: 0x00336D58 File Offset: 0x00334F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261850, XrefRangeEnd = 261855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700432D RID: 17197
			// (get) Token: 0x0600D892 RID: 55442 RVA: 0x00336D8C File Offset: 0x00334F8C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D893 RID: 55443 RVA: 0x0006977B File Offset: 0x0006797B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004327 RID: 17191
			// (get) Token: 0x0600D894 RID: 55444 RVA: 0x00336DCC File Offset: 0x00334FCC
			// (set) Token: 0x0600D895 RID: 55445 RVA: 0x00069784 File Offset: 0x00067984
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004328 RID: 17192
			// (get) Token: 0x0600D896 RID: 55446 RVA: 0x00336DF4 File Offset: 0x00334FF4
			// (set) Token: 0x0600D897 RID: 55447 RVA: 0x0006979F File Offset: 0x0006799F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004329 RID: 17193
			// (get) Token: 0x0600D898 RID: 55448 RVA: 0x00336E24 File Offset: 0x00335024
			// (set) Token: 0x0600D899 RID: 55449 RVA: 0x000697BE File Offset: 0x000679BE
			public unsafe DeathScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeathScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700432A RID: 17194
			// (get) Token: 0x0600D89A RID: 55450 RVA: 0x00336E54 File Offset: 0x00335054
			// (set) Token: 0x0600D89B RID: 55451 RVA: 0x000697DD File Offset: 0x000679DD
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x1700432B RID: 17195
			// (get) Token: 0x0600D89C RID: 55452 RVA: 0x00336E7C File Offset: 0x0033507C
			// (set) Token: 0x0600D89D RID: 55453 RVA: 0x000697F8 File Offset: 0x000679F8
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009185 RID: 37253
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009186 RID: 37254
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009187 RID: 37255
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009188 RID: 37256
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x04009189 RID: 37257
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400918A RID: 37258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400918B RID: 37259
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400918C RID: 37260
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400918D RID: 37261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400918E RID: 37262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400918F RID: 37263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B3E RID: 2878
		[ObfuscatedName("ScheduleOne.UI.DeathScreen+<<RespawnClicked>g__Routine|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D89E RID: 55454 RVA: 0x00336EA4 File Offset: 0x003350A4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique()
			{
				Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeathScreen>.NativeClassPtr, "<<RespawnClicked>g__Routine|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>1__state");
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>2__current");
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>4__this");
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681233);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681234);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681235);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681236);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681237);
				DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681238);
			}

			// Token: 0x0600D89F RID: 55455 RVA: 0x00336F84 File Offset: 0x00335184
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8A0 RID: 55456 RVA: 0x00336FCC File Offset: 0x003351CC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8A1 RID: 55457 RVA: 0x00337000 File Offset: 0x00335200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261855, XrefRangeEnd = 261923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004331 RID: 17201
			// (get) Token: 0x0600D8A2 RID: 55458 RVA: 0x0033703C File Offset: 0x0033523C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8A3 RID: 55459 RVA: 0x0033707C File Offset: 0x0033527C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261923, XrefRangeEnd = 261928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004332 RID: 17202
			// (get) Token: 0x0600D8A4 RID: 55460 RVA: 0x003370B0 File Offset: 0x003352B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8A5 RID: 55461 RVA: 0x00069813 File Offset: 0x00067A13
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700432E RID: 17198
			// (get) Token: 0x0600D8A6 RID: 55462 RVA: 0x003370F0 File Offset: 0x003352F0
			// (set) Token: 0x0600D8A7 RID: 55463 RVA: 0x0006981C File Offset: 0x00067A1C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700432F RID: 17199
			// (get) Token: 0x0600D8A8 RID: 55464 RVA: 0x00337118 File Offset: 0x00335318
			// (set) Token: 0x0600D8A9 RID: 55465 RVA: 0x00069837 File Offset: 0x00067A37
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004330 RID: 17200
			// (get) Token: 0x0600D8AA RID: 55466 RVA: 0x00337148 File Offset: 0x00335348
			// (set) Token: 0x0600D8AB RID: 55467 RVA: 0x00069856 File Offset: 0x00067A56
			public unsafe DeathScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeathScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeathScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009190 RID: 37264
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009191 RID: 37265
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009192 RID: 37266
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009193 RID: 37267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009194 RID: 37268
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009195 RID: 37269
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009196 RID: 37270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009197 RID: 37271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009198 RID: 37272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
