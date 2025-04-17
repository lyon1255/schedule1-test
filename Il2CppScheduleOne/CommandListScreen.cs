using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.MainMenu;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x0200016D RID: 365
	public class CommandListScreen : MainMenuScreen
	{
		// Token: 0x06001D7D RID: 7549 RVA: 0x000CC1F8 File Offset: 0x000CA3F8
		// Note: this type is marked as 'beforefieldinit'.
		static CommandListScreen()
		{
			Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "CommandListScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr);
			CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "CommandEntryContainer");
			CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "CommandEntryPrefab");
			CommandListScreen.NativeFieldInfoPtr_commandEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "commandEntries");
			CommandListScreen.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, 100666651);
			CommandListScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, 100666652);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000CC28C File Offset: 0x000CA48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106049, XrefRangeEnd = 106099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandListScreen.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x000CC2C0 File Offset: 0x000CA4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106099, XrefRangeEnd = 106107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandListScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandListScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00010A8E File Offset: 0x0000EC8E
		public CommandListScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x000CC2FC File Offset: 0x000CA4FC
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x00010A97 File Offset: 0x0000EC97
		public unsafe RectTransform CommandEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x000CC32C File Offset: 0x000CA52C
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x00010AB6 File Offset: 0x0000ECB6
		public unsafe RectTransform CommandEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x000CC35C File Offset: 0x000CA55C
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x00010AD5 File Offset: 0x0000ECD5
		public unsafe List<RectTransform> commandEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_commandEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_commandEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeFieldInfoPtr_CommandEntryContainer;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeFieldInfoPtr_CommandEntryPrefab;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeFieldInfoPtr_commandEntries;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
