using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000689 RID: 1673
	public class GameSettingsWindow : MonoBehaviour
	{
		// Token: 0x060095B5 RID: 38325 RVA: 0x00265FC8 File Offset: 0x002641C8
		// Note: this type is marked as 'beforefieldinit'.
		static GameSettingsWindow()
		{
			Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "GameSettingsWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr);
			GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "ConsoleToggle");
			GameSettingsWindow.NativeFieldInfoPtr_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "Blocker");
			GameSettingsWindow.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681799);
			GameSettingsWindow.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681800);
			GameSettingsWindow.NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681801);
			GameSettingsWindow.NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681802);
			GameSettingsWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681803);
		}

		// Token: 0x060095B6 RID: 38326 RVA: 0x00266084 File Offset: 0x00264284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268764, XrefRangeEnd = 268774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x002660B8 File Offset: 0x002642B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268774, XrefRangeEnd = 268782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x002660EC File Offset: 0x002642EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268782, XrefRangeEnd = 268784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings(GameSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x00266130 File Offset: 0x00264330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268784, XrefRangeEnd = 268788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsoleToggled(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x00266170 File Offset: 0x00264370
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSettingsWindow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x00048C34 File Offset: 0x00046E34
		public GameSettingsWindow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x060095BC RID: 38332 RVA: 0x002661AC File Offset: 0x002643AC
		// (set) Token: 0x060095BD RID: 38333 RVA: 0x00048C3D File Offset: 0x00046E3D
		public unsafe Toggle ConsoleToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x060095BE RID: 38334 RVA: 0x002661DC File Offset: 0x002643DC
		// (set) Token: 0x060095BF RID: 38335 RVA: 0x00048C5C File Offset: 0x00046E5C
		public unsafe GameObject Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064F2 RID: 25842
		private static readonly IntPtr NativeFieldInfoPtr_ConsoleToggle;

		// Token: 0x040064F3 RID: 25843
		private static readonly IntPtr NativeFieldInfoPtr_Blocker;

		// Token: 0x040064F4 RID: 25844
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040064F5 RID: 25845
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040064F6 RID: 25846
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0;

		// Token: 0x040064F7 RID: 25847
		private static readonly IntPtr NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0;

		// Token: 0x040064F8 RID: 25848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
