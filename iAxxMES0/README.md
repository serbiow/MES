# iAxxMES0

# TODO:

#Tratativas de Erro
# - (consertar isso) Fazer tratativas de erros (perdeu conex�o, por exemplo)
# - tratativas de m�quina e todas as m�quinas (campos em branco, campos nulos, sem conex�o)

#Implementa��es
# - CALCULO DE EFICI�NCIA
	# - Fazer os c�lculos e relat�rios de efici�ncia corretos
	# - Fazer a indisponibilidade de m�quinas espec�ficas
# - Fazer o CRUD completo de ARTIGOS (deve ter Filtro e Ordena��o por Artigo no dashboard)
# - Fazer o artigo poder ser atribu�do a m�quinas especificas
# - Exibir a linha do tempo dos artigos

#Calend�rio
# - V�rios calend�rios diferentes, mas uma m�quina s� pode ter um calend�rio
# - Dias anteriores n�o podem mais ser alterados
# - Poder definir exce��es para as datas que ja tem indisponibilidade (exemplo: algum domingo a m�quina vai rodar)
# - Colocar op��es e defini��es para cargos (manh�, tarde e noite)

#Informa��es do Artigo
# - ID
# - Descri��o
# - Composi��o (op��es, a soma tem que ser IGUAL 100%) - Deciamal com 2 casas
	# - Precisa ter uma tabela para o tipo de fibra
		# - Tipos de fibra:
		# - (V�o mandar no zap)
# - RPM m�mino, m�ximo e ponderado
# - Rendimento por quilos *(1000 voltas)*
# - Rendimento por metros *(1000 voltas)*

# - As m�quinas devem ter bloqueios de artigos (artigos que n�o podem rodar na m�quina) (pq, quem e quando?)
# - Essas defini��es podem ser feitas em v�rias m�uqinas ao mesmo tempo

#Extra
# - Fazer op��es para importar e exportar dados pelo excel (Update de Maquinas e Artigos)
# - Implementar as OTs (isso deve ser discutido � fundo ainda)